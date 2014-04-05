using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDCheck.Vista
{
    public partial class frmCambiarPasword : Form
    {
        public frmCambiarPasword(String dnitmp)
        {
            InitializeComponent();
        this.dni = dnitmp;
        }

        string dni;

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Controlador.Encriptador clsEncriptador = new Controlador.Encriptador();

            Modelo.ConexionBD cnx = new Modelo.ConexionBD();

           
            // verifico si existe el usuario y la contraseña
            if (cnx.VerificarUsuario(dni, clsEncriptador.EncriptarPasword(this.txtActual.Text)) == true)
            {
                //procedo a actualizar la contraseña
                Controlador.Administrador clsAdministrador = new Controlador.Administrador();

                Modelo.Administrador_BD clsAdministradorBD = new Modelo.Administrador_BD();
              

                if (clsAdministradorBD.VerificarSiExisteAdministrador(dni) == true)
                {
                    //si existe actualizo datos 
                   

                    clsAdministrador.idpersonal = dni;
                    clsAdministrador.pasword = clsEncriptador.EncriptarPasword(this.txtNueva.Text);


                    int resultado = Modelo.Administrador_BD.ActualizarDatosdAdministrador(clsAdministrador);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Su nueva contraseña , ya se encuentra activada.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar los datos", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }



                }
               
              
            }

            else
            {
                MessageBox.Show("Por  favor ingrese su contraseña actual");
            }
            //*     

        }

        private void frmCambiarPasword_Load(object sender, EventArgs e)
        {

        }
    }
}

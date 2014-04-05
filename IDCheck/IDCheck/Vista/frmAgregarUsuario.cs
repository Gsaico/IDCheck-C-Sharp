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
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (this.txtDNI.Text != null && this.txtPasword.Text !=null)
            {

                Controlador.Administrador clsAdministrador = new Controlador.Administrador();

                Modelo.Administrador_BD clsAdministradorBD = new Modelo.Administrador_BD();



                if (clsAdministradorBD.VerificarSiExisteAdministrador(this.txtDNI.Text) == false)
                {
                    // si no existe inserto
                    Controlador.Encriptador clsEncriptador = new Controlador.Encriptador();

                    clsAdministrador.idpersonal = this.txtDNI.Text.Trim();
                    clsAdministrador.pasword = clsEncriptador.EncriptarPasword(this.txtPasword.Text.Trim());

                    int resultado = Modelo.Administrador_BD.AgregarDatosdAdministrador(clsAdministrador);
                    if (resultado > 0)
                    {
                        MessageBox.Show("La nueva cuenta de usuario se habilito correctamente, Ahora Usted puede utilizar el software", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar los datos ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    


                }

            }
            else
            {

                MessageBox.Show("Por favor, vuelva a ingresar  el usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
        }
    }
}

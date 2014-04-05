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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verifico el numero de intentos que lleva
            intentos = intentos + 1;
            if (intentos == 4)
            {
                MessageBox.Show("el limite de intentos termino");
                this.Close();

            }
            
            Modelo.ConexionBD cnx= new Modelo.ConexionBD();

            Controlador.Encriptador clsEncriptador = new Controlador.Encriptador();
            // verifico si existe el usuario y la contraseña
            if (cnx.VerificarUsuario(txtDNI.Text, clsEncriptador.EncriptarPasword(txtpasword.Text)) == true)
            {
                             
                Vista.IDCheck nuevo = new Vista.IDCheck(txtDNI.Text);
                this.Hide();
                nuevo.Show();
            }

            else
            {
                MessageBox.Show("Acceso Denegado");
            }
            //*     

            

          


        }

     

        void habilitarcontroles() {
            maskedTextBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            btnGuardar.Enabled = true;
        }
        void deshabilitarcontroles()
        {
            maskedTextBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Modelo.ConexionBD clsConexionBD = new Modelo.ConexionBD();

            if (clsConexionBD.ExistenUsuariosAdministradores() == false)
            {

                MessageBox.Show("Usted debe habilitar una  nueva cuenta de usuario.");
                habilitarcontroles();
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (maskedTextBox1.Text != null && textBox2.Text == textBox3.Text)
            {

                Controlador.Administrador clsAdministrador = new Controlador.Administrador();

                Modelo.Administrador_BD clsAdministradorBD = new Modelo.Administrador_BD();



                if (clsAdministradorBD.VerificarSiExisteAdministrador(maskedTextBox1.Text) == false)
                {
                    // si no existe inserto
                    Controlador.Encriptador clsEncriptador = new Controlador.Encriptador();

                    clsAdministrador.idpersonal = maskedTextBox1.Text.Trim();
                    clsAdministrador.pasword = clsEncriptador.EncriptarPasword(textBox2.Text.Trim());

                    int resultado = Modelo.Administrador_BD.AgregarDatosdAdministrador(clsAdministrador);
                    if (resultado > 0)
                    {
                        MessageBox.Show("La nueva cuenta de usuario se habilito correctamente, Ahora Usted puede utilizar el software", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar los datos ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    deshabilitarcontroles();


                }
               
            }
            else {

                MessageBox.Show("Por favor, Repita la contraseña", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            
            
            }




            
            }
            


       

        

    }
}

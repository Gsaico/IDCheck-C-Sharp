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
            if (cnx.VerificarUsuario(txtDNI.Text,  clsEncriptador.EncriptarPasword(txtpasword.Text)) == true)
            {
                
                Vista.IDCheck nuevo = new Vista.IDCheck();
                this.Hide();
                nuevo.Show();
            }

            else
            {
                MessageBox.Show("Acceso Denegado");
            }
            //*     


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

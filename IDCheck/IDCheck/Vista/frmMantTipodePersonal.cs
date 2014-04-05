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
    public partial class frmMantTipodePersonal : Form
    {
        public frmMantTipodePersonal()
        {
            InitializeComponent();
        }

        private void frmMantTipodePersonal_Load(object sender, EventArgs e)
        {
            Modelo.TipoPersonal_BD clsTipoPersonalBD = new Modelo.TipoPersonal_BD();
  
        
            dataGridViewTipoPersonal.DataSource = clsTipoPersonalBD.CargarTipopersonal ();
            txtTipoPersonal.Select();
            txtTipoPersonal.Focus();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador.TipoPersonal clsTipoPersonal = new Controlador.TipoPersonal();
            Modelo.TipoPersonal_BD clsTipoPersonalBD = new Modelo.TipoPersonal_BD();

            clsTipoPersonal.nombreTipoPersonal = txtTipoPersonal.Text;
            clsTipoPersonal.tipoPersonal = clsTipoPersonalBD.UltimoIDdeTipoPersonal() + 1;



            if (clsTipoPersonalBD.VerificarSiExisteelTipodePersonal(txtTipoPersonal.Text) == true)
            {

                MessageBox.Show("El tipo de personal ya existe", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else {

                int resultado = Modelo.TipoPersonal_BD.AgregarNuevoTipodePersonal(clsTipoPersonal);

                if (resultado > 0)
                {
                    MessageBox.Show("La actualizacion se realizo con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                dataGridViewTipoPersonal.DataSource = clsTipoPersonalBD.CargarTipopersonal();
            
            }


           


        }

       
    }
}

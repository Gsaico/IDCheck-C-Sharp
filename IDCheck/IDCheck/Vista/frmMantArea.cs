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
    public partial class frmMantArea : Form
    {
        public frmMantArea()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Controlador.Area clsArea = new Controlador.Area();
            Modelo.Area_BD clsAreaBD = new Modelo.Area_BD();

            clsArea.nombrearea = txtArea.Text;
            clsArea.idarea = clsAreaBD.UltimoIDdeArea() + 1;



            if (clsAreaBD.VerificarSiExisteArea(txtArea.Text) == true)
            {

                MessageBox.Show("El area ya existe", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {

                int resultado = Modelo.Area_BD.AgregarNuevaArea(clsArea);

                if (resultado > 0)
                {
                    MessageBox.Show("La actualizacion se realizo con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                dataGridViewArea.DataSource = clsAreaBD.CargarArea();

            }
        }

        private void frmMantArea_Load(object sender, EventArgs e)
        {
            Modelo.Area_BD clsAreaBD = new Modelo.Area_BD();


            dataGridViewArea.DataSource = clsAreaBD.CargarArea();
        }
    }
}

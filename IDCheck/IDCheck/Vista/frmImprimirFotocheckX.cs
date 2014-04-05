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
    public partial class frmImprimirFotocheckX : Form
    {
        public frmImprimirFotocheckX(string tmpdni)
        {
            InitializeComponent();
            this.dni = tmpdni;
        }
        string dni;
        private void frmImprimirFotocheckX_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSpersonal.personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.DSpersonal.personal,dni);

            this.reportViewer1.RefreshReport();
        }
    }
}

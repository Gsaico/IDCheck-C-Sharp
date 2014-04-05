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
    public partial class IDCheck : Form
    {
        public IDCheck(string dnitmp)
        {
            InitializeComponent();
            this.dni = dnitmp;
        }

        string dni;

        
        private void actualizarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmPersonal hijo = new Vista.frmPersonal();
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void autorizarAccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmAutorizarAcceso hijo = new Vista.frmAutorizarAcceso();
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmRegistrodePersonal hijo = new Vista.frmRegistrodePersonal();
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void IDCheck_Load(object sender, EventArgs e)
        {

        }

        private void tipoDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmMantTipodePersonal hijo = new Vista.frmMantTipodePersonal();
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Vista.frmMantArea hijo = new Vista.frmMantArea();
            hijo.MdiParent = this;
            hijo.Show(); 
        
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmCambiarPasword hijo = new  Vista.frmCambiarPasword(dni);
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmAgregarUsuario hijo = new Vista.frmAgregarUsuario();
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmEmpresas hijo = new Vista.frmEmpresas();
            hijo.MdiParent = this;
            hijo.Show(); 
        }
    }
}

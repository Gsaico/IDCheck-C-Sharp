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
        public IDCheck()
        {
            InitializeComponent();
        }

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
    }
}

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
    public partial class frmRegistrodePersonal : Form



    {
    private static String  Verde_OFF="0";
    private static  String Verde_ON="1";
    private static  String Rojo_OFF="2";
    private static  String Rojo_ON="3"; 



        public frmRegistrodePersonal()
        {
            InitializeComponent();


            serialPort1.PortName = "COM4";//puerto serial
            serialPort1.BaudRate = 9600;//potencial en batios

            try
            {
                serialPort1.Open();

                
            }
            catch (Exception err)
            {
                MessageBox.Show("No se pudo conectar a el puerto especificado\n" + err, "Error");
            }
        }

        private void frmRegistrodePersonal_Load(object sender, EventArgs e)
        {

        }

        private void btnEncenderrojo_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Rojo_ON);
        }

        private void btnApagarverde_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Verde_OFF);
        }

        private void btnApagarRojo_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Rojo_OFF);
        }

        private void btnEncenderverde_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Verde_ON);
        }

        private void frmRegistrodePersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(Rojo_OFF);
                serialPort1.Write(Verde_OFF);
                serialPort1.Close();  //cierro el puerto
            
            }

            
        }
    }
}

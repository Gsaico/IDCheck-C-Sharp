using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDCheck.Vista
{
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }
        byte[] tempfoto;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo.PersonalBD clspersonalbd = new Modelo.PersonalBD();
            Controlador.Personal clsPersonal = new Controlador.Personal();

            if (tempfoto != null)
            {
                if (clspersonalbd.VerificarSiExistePersonal(txtDNI.Text) == true)
                {
                    //si existe actualizo datos de personal

                    clsPersonal.idpersonal = txtDNI.Text.Trim();
                    clsPersonal.nombres = txtNombres.Text.Trim();
                    clsPersonal.apellidos = txtApellidos.Text.Trim();
                    clsPersonal.fechanac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
                    clsPersonal.cargo = txtcargo.Text.Trim();
                    clsPersonal.foto = tempfoto;

                    int resultado = Modelo.PersonalBD.ActualizarDatosdPersonal(clsPersonal);
                    if (resultado > 0)
                    {
                        MessageBox.Show("La actualizacion se realizo con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar los datos del personal", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }



                }
                else
                {
                    // si no existe inserto el personal nuevo

                    clsPersonal.idpersonal = txtDNI.Text.Trim();
                    clsPersonal.nombres = txtNombres.Text.Trim();
                    clsPersonal.apellidos = txtApellidos.Text.Trim();
                    clsPersonal.fechanac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
                    clsPersonal.cargo = txtcargo.Text.Trim();
                    clsPersonal.foto = tempfoto;

                    int resultado = Modelo.PersonalBD.AgregarDatosdPersonal(clsPersonal);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Los datos del personal nuevo se Grabo Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar los datos del personal nuevo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            else
            {

                MessageBox.Show("Debe ingresar la foto del personal.", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
            
            
            
            
            


        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDNI.Text = null;
            txtNombres.Text = null;
            txtApellidos.Text = null;
            dtpFechaNacimiento.Text = null;
            txtcargo.Text = null;
            picFoto.Image = null;
            //limpio la variable foto
            tempfoto = null;

        
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Vista.frmImprimirFotocheck frmreportex = new Vista.frmImprimirFotocheck(txtDNI.Text);
            frmreportex.Show();

        }

        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {

            string rutaimagen = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaimagen = openFileDialog1.FileName;
                    picFoto.Enabled = true;


                    picFoto.Image = Image.FromFile(rutaimagen);

                
                    // convierto la imagen del Picture box  Byte
                    tempfoto = imageToByteArray(picFoto.Image);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: no se pudo leer el archivo del disco. Original error: " + ex.Message);
                }
            }




        }

        // image  de picture box a Byte
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        //Byte a imagen para picture box
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                

           

                Modelo.PersonalBD clspersonalbd = new Modelo.PersonalBD();


                if (clspersonalbd.VerificarSiExistePersonal(txtDNI.Text))
                {
                    //si existe el personal  recupero los datos de l personal a mis controles
                    Controlador.Personal clsPersonal = new Controlador.Personal();
                    //  Modelo.PersonalBD clspersonalbdx = new Modelo.PersonalBD();

                    clsPersonal.idpersonal = txtDNI.Text;


                    clsPersonal = clspersonalbd.BuscarPersonalXdni(clsPersonal);
                    txtDNI.Text = clsPersonal.idpersonal;
                    label6.Text = txtDNI.Text;
                    label7.Text = txtDNI.Text;
                    txtNombres.Text = clsPersonal.nombres;
                    txtApellidos.Text = clsPersonal.apellidos;
                    dtpFechaNacimiento.Text = clsPersonal.fechanac;
                    txtcargo.Text = clsPersonal.cargo;
                    picFoto.Image = byteArrayToImage(clsPersonal.foto);
                    // coloca la fot en la variable temfoto para su actualizacion
                    tempfoto = imageToByteArray(picFoto.Image); 
                }
                else {

                    MessageBox.Show(" El personal no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
            }
        }

        private void txtDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            txtDNI.Select();
            txtDNI.Focus();
        }
    }
}

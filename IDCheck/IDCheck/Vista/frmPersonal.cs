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


using System.Collections;


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

            if (tempfoto != null && txtDNI.Text.Length ==8)
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
                        limpiarControles();
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
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar los datos del personal nuevo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            else
            {

                MessageBox.Show("Debe completar los datos del personal.", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
            
            
            
            
            


        }

        void limpiarControles() {

            txtDNI.Text = null;
            txtNombres.Text = null;
            txtApellidos.Text = null;
            dtpFechaNacimiento.Text = null;
            txtcargo.Text = null;
            picFoto.Image = null;
            //limpio la variable foto
            tempfoto = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarControles();
        
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

                    txtNombres.Text = clsPersonal.nombres;
                    txtApellidos.Text = clsPersonal.apellidos;
                    dtpFechaNacimiento.Text = clsPersonal.fechanac;
                    txtcargo.Text = clsPersonal.cargo;

                    picFoto.Image = byteArrayToImage(clsPersonal.foto);
                    // coloca la fot en la variable temfoto para su actualizacion
                    tempfoto = imageToByteArray(picFoto.Image);

                    // MemoryStream stream = new MemoryStream(clsPersonal.foto);
                    // picFoto.Image = Image.FromStream(stream);







                }

                else
                {

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

       // private void txtDNI_Validating(object sender, CancelEventArgs e)
       // {
           // if (txtDNI.Text.Length == 0)
          //  {
         //       e.Cancel = true;
         //       this.errorProvider1.SetError(this.txtDNI, "Ingrese el DNI del Colaborador.");
         //   }
         //   else
         //   {
          //      this.errorProvider1.SetError(this.txtDNI, null);
         //   }
      //  }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombres.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.txtNombres, "Ingrese el Nombre del Colaborador.");
            }
            else
            {
                this.errorProvider1.SetError(this.txtNombres, null);
            }
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidos.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.txtApellidos, "Ingrese el Apellido del Colaborador.");
            }
            else
            {
                this.errorProvider1.SetError(this.txtApellidos, null);
            }
        }

        private void dtpFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFechaNacimiento.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.dtpFechaNacimiento, "Ingrese la Fecha de Nacimiento del Colaborador. ");
            }
            else
            {
                this.errorProvider1.SetError(this.dtpFechaNacimiento, null);
            }
        }

        private void txtcargo_Validating(object sender, CancelEventArgs e)
        {
            if (txtcargo.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.txtcargo, "Ingrese el cargo que desempeña el Colaborador. ");
            }
            else
            {
                this.errorProvider1.SetError(this.txtcargo, null);
            }
        }
    }
}

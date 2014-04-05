using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDCheck.Vista
{
    public partial class frmAutorizarAcceso : Form
    {
        public frmAutorizarAcceso()
        {
            InitializeComponent();

          

        }

        private void frmAutorizarAcceso_Load(object sender, EventArgs e)
        {
            cargarCombos();
            txtDNI.Select();
            txtDNI.Focus();

            Controlador.Servidor clsServidor = new Controlador.Servidor();
            Modelo.Servidor_BD clsServidor_BD = new Modelo.Servidor_BD();

            clsServidor = clsServidor_BD.FechayHoradelServidor();
         //   lblFecha.Text = DateTime.ToString("yyyyMMdd") ;

            var dt = clsServidor.datetimeservidor;
            string output = dt.ToString(@"yyyy/MM/dd", CultureInfo.InvariantCulture);
            lblFecha.Text = output;
        }
        //Byte a imagen para picture box

        public void cargarCombos(){


            
            Modelo.Area_BD clsAreabd = new Modelo.Area_BD();

            //cmbArea.Items.Clear(); 
            cmbArea.DataSource = clsAreabd.CargarArea();
            cmbArea.DisplayMember = "NombreArea";
            cmbArea.ValueMember = "idArea";
        
           

        Modelo.TipoPersonal_BD clsTipoPersonalBD = new Modelo.TipoPersonal_BD();

        //cmdTipoPersonal.Items.Clear(); 
        cmdTipoPersonal.DataSource = clsTipoPersonalBD.CargarTipopersonal();
        cmdTipoPersonal.DisplayMember = "NombreTipoPersonal";
        cmdTipoPersonal.ValueMember = "idTipoPersonal";



        
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


                    this.lblDNI.Text = clsPersonal.nombres + " "+clsPersonal.apellidos;
                    
                    //cargo la foto en picture box
                    picFoto.Image = byteArrayToImage(clsPersonal.foto);
                   
                }
                else
                {

                    MessageBox.Show(" El personal no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            //////////////





            Modelo.Acceso_BD clsAccesobd = new Modelo.Acceso_BD();


            if (clsAccesobd.VerificarSiExisteIDacceso(txtDNI.Text))
                {
                    //si existe el Id l  recupero los datos de l personal a mis controles
                    Controlador.Acceso clsAcceso = new Controlador.Acceso();


                    clsAcceso.idpersonal = txtDNI.Text;


                    clsAcceso = clsAccesobd.BuscarAccesoXIDpersonal(clsAcceso);


                    var dt = clsAcceso.fecha;
                    string output = dt.ToString(@"yyyy/MM/dd", CultureInfo.InvariantCulture);
                    lblFecha.Text = output;
                                 
 
                    this.dtpDesde.Value = clsAcceso.fechadesde;
                    this.dtpHasta.Value = clsAcceso.fechahasta;
                    this.txtRUC.Text = clsAcceso.idempresacolaboradora;

                   this.cbxEssalud.Checked = (clsAcceso.essalud == "1" ? true : false);
                    this.cbxSCTRsalud.Checked = (clsAcceso.sctrsalud == "1" ? true : false);
                    this.cbxSCTRpensiones.Checked = ( clsAcceso.sctrpensiones == "1" ? true : false);
                   this.cbdPDTplame.Checked =  (clsAcceso.pdtplame == "1" ? true : false);
                    this.cbxAFP.Checked=  ( clsAcceso.afp == "1" ? true : false);
                   this.cbxONP.Checked = (clsAcceso.onp  == "1" ? true : false);

                   this.txtNota.Text = clsAcceso.nota;



                   this.cmdTipoPersonal.SelectedIndex = (int.Parse(clsAcceso.idtipopersonal) - 1);


                this.cmbArea.SelectedIndex= (int.Parse(clsAcceso.idarea) - 1);
         
                    


                }

                
              


            
            ////////////








        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Modelo.EmpresaColaboradora_BD clsEmpresaColaboradorabd = new Modelo.EmpresaColaboradora_BD();


                if (clsEmpresaColaboradorabd.VerificarSiExisteRUC(this.txtRUC.Text))
                {
                    //si existe el RUC muestro en lbl la empresa
                    Controlador.EmpresaColaboradora clsEmpresaColaboradora = new Controlador.EmpresaColaboradora();
                    //  Modelo.PersonalBD clspersonalbdx = new Modelo.PersonalBD();

                    clsEmpresaColaboradora.idEmpresaColaboradora = txtRUC.Text;

                    clsEmpresaColaboradora = clsEmpresaColaboradorabd.BuscarXRUC(clsEmpresaColaboradora);


                    this.lblRUC.Text = clsEmpresaColaboradora.nombreEmpresa;

                }
                else
                {

                    MessageBox.Show(" El numero de RUC no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }


        private void  LimpiarObjetos(){

            txtDNI.Text = null;
            dtpDesde.Text = null;
            dtpHasta.Text = null;
            cargarCombos();
            cbxEssalud.Checked = false;
            cbxSCTRsalud.Checked = false;
            cbxSCTRpensiones.Checked = false;
            cbdPDTplame.Checked = false;
            cbxAFP.Checked = false;
            cbxONP.Checked = false;
            txtNota.Text = null;
            picFoto.Image = null;
 


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length == 8 && txtRUC.Text.Length == 11 )
            {
            
      Modelo.PersonalBD clspersonalbd = new Modelo.PersonalBD();
            Controlador.Personal clsPersonal = new Controlador.Personal();

           
            Modelo.Acceso_BD clsAccesobd = new Modelo.Acceso_BD();
            Controlador.Acceso clsAcceso = new Controlador.Acceso();

            Controlador.Servidor clsSservidor = new Controlador.Servidor();
            Modelo.Servidor_BD clsServidorBD = new Modelo.Servidor_BD();
            clsSservidor = clsServidorBD.FechayHoradelServidor();

            var dt = clsSservidor.datetimeservidor;
            string output = dt.ToString(@"yyyy/MM/dd hh:mm:ss", CultureInfo.InvariantCulture);



                if (clsAccesobd.VerificarSiExisteIDacceso(txtDNI.Text) == true)
                {
                    //si existe actualizo datos de personal

                    clsAcceso.idpersonal = txtDNI.Text;
                    clsAcceso.fecha = clsSservidor.datetimeservidor;

                    lblFecha.Text = output;
                    clsAcceso.fechadesde = dtpDesde.Value;
                    clsAcceso.fechahasta = dtpHasta.Value;
                    clsAcceso.nota = txtNota.Text;

                    clsAcceso.essalud = (this.cbxEssalud.Checked == true ? "1" : "0");


                    clsAcceso.sctrsalud = (this.cbxSCTRsalud.Checked == true ? "1" : "0");
                    clsAcceso.sctrpensiones =  (this.cbxSCTRpensiones.Checked == true ? "1" : "0");
                    clsAcceso.pdtplame =  (this.cbdPDTplame.Checked == true ? "1" : "0");
                    clsAcceso.afp =  (this.cbxAFP.Checked == true ? "1" : "0");
                    clsAcceso.onp =  (this.cbxONP.Checked == true ? "1" : "0");


                    clsAcceso.idarea = Convert.ToString(this.cmbArea.SelectedIndex+1);
                    clsAcceso.idempresacolaboradora = this.txtRUC.Text;

                   // Controlador.TipoPersonal



                    clsAcceso.idtipopersonal = Convert.ToString(this.cmdTipoPersonal.SelectedIndex+1);


                    int resultado = Modelo.Acceso_BD.Actualizardatosdeacceso(clsAcceso);
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

                    clsAcceso.idpersonal = txtDNI.Text;
                    clsAcceso.fecha = clsSservidor.datetimeservidor;

                   
                

                   lblFecha.Text = output ;


                    clsAcceso.fechadesde = dtpDesde.Value;
                    clsAcceso.fechahasta = dtpHasta.Value;
                    clsAcceso.nota = txtNota.Text;

                    clsAcceso.essalud = (this.cbxEssalud.Checked == true ? "1" : "0");


                    clsAcceso.sctrsalud = (this.cbxSCTRsalud.Checked == true ? "1" : "0");
                    clsAcceso.sctrpensiones = (this.cbxSCTRpensiones.Checked == true ? "1" : "0");
                    clsAcceso.pdtplame = (this.cbdPDTplame.Checked == true ? "1" : "0");
                    clsAcceso.afp = (this.cbxAFP.Checked == true ? "1" : "0");
                    clsAcceso.onp = (this.cbxONP.Checked == true ? "1" : "0");


                    clsAcceso.idarea = Convert.ToString(this.cmbArea.SelectedIndex + 1);
                    clsAcceso.idempresacolaboradora = this.txtRUC.Text;
                    clsAcceso.idtipopersonal = Convert.ToString(this.cmdTipoPersonal.SelectedIndex + 1);


                    int resultado = Modelo.Acceso_BD.insertardatosdeacceso(clsAcceso);
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

                MessageBox.Show("Debe completar los datos para autorizar el acceso.", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbArea.ValueMember);

           //Número = Int32.Parse(comboBox1.ValueMember);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //int cad= cmdTipoPersonal.SelectedValue.;

         //   MessageBox.Show(.ToString);  

         //   this.cmdTipoPersonal.Items.IndexOf(int.Parse (clsAcceso.idtipopersonal) - 1)

        }

        

        
    }
}

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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Controlador.LogicaAcceso clsLogicaacceso = new Controlador.LogicaAcceso();
                clsLogicaacceso.idacceso = txtDNI.Text;

                Modelo.LogicaAcceso_BD clsLogicaAccesoBD = new Modelo.LogicaAcceso_BD();
                clsLogicaacceso=clsLogicaAccesoBD.VerificarAutorizacion(clsLogicaacceso);

                if (clsLogicaacceso.dni != null)
                {
                    //existe el  acceso parta el personal pero no se si esta activado su pase

                    lblNombres.Text = clsLogicaacceso.nombres;
                    lblApellidos.Text = clsLogicaacceso.apellidos;
                    lblDNI.Text = clsLogicaacceso.dni;
                    lblNombreEmpresa.Text = clsLogicaacceso.nombreempresa;
                    lblTipoPersonal.Text = clsLogicaacceso.nombretipopersonal;
                    picFoto.Image = byteArrayToImage(clsLogicaacceso.foto);

                    // aqui verifico el estado de su pase
                     
                    if (clsLogicaacceso.autorizacion  == 1) {
                        serialPort1.Write(Verde_ON);
                lblAcceso.Text="Acceso Permitido";
                lblAcceso.ForeColor=Color.Green;

                    // ---> verifico el ultimo registro de ingreso y salidas
                Controlador.Registro clsRegistro = new  Controlador.Registro();
                clsRegistro.idAcceso = clsLogicaacceso.dni;

                        Modelo.Registro_BD  clsRegistroBD =new  Modelo.Registro_BD();

               clsRegistro= clsRegistroBD.BuscarUltimoRegistrodeESxIDACCESO(clsRegistro);
                // fin <---
          
              
                   
                   int estado=3;
                   
                   
                   if (clsRegistro.idEstado != null) {

                       estado = int.Parse(clsRegistro.idEstado);
                   
                   }


                   Controlador.Registro clsRegistrox = new Controlador.Registro();
                  // Modelo.Registro_BD clsRegistroBDx = new Modelo.Registro_BD();
                   
                   
                   
                if (estado==1){
                
               
                    //el personal sale de las instalaciones
                    

                clsRegistrox.idTipoPersonal = clsLogicaacceso.idTipoPersonal;

                clsRegistrox.idEmpresaColaboradora = clsLogicaacceso.idEmpresaColaboradora;
                clsRegistrox.idAcceso = clsLogicaacceso.dni;
                clsRegistrox.idEstado  ="0";
                Modelo.Registro_BD.GrabarAcceso(clsRegistrox);//retorna 1 si se guardo correctamente

                           
                    
                }else if (estado==0){
                     //el personal ingresa a las instalaciones
                    clsRegistrox.idTipoPersonal = clsLogicaacceso.idTipoPersonal;

                    clsRegistrox.idEmpresaColaboradora = clsLogicaacceso.idEmpresaColaboradora;
                    clsRegistrox.idAcceso = clsLogicaacceso.dni;
                    clsRegistrox.idEstado = "1";
                    Modelo.Registro_BD.GrabarAcceso(clsRegistrox);//retorna 1 si se guardo correctamente
               
                
                }else{
                    clsRegistrox.idTipoPersonal = clsLogicaacceso.idTipoPersonal;

                    clsRegistrox.idEmpresaColaboradora = clsLogicaacceso.idEmpresaColaboradora;
                    clsRegistrox.idAcceso = clsLogicaacceso.dni;
                    clsRegistrox.idEstado = "1";
                    Modelo.Registro_BD.GrabarAcceso(clsRegistrox);//retorna 1 si se guardo correctamente
                
                    
                }
                
                
                        
                
                
                
                
                
                    
                    
            } else if (clsLogicaacceso.autorizacion == 0) {
                serialPort1.Write(Rojo_ON);  //prender 3segundos
                lblAcceso.Text="ACCESO DENEGADO";
                lblAcceso.ForeColor=Color.Red;
                    
            }







                }
                else { 
                
                //no existe personal
                    //poner foto vacia

                    picFoto.Image = null;

                
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
    }
}

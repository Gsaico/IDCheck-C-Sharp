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
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo.EmpresaColaboradora_BD clsEmpresaColaboradorabd = new Modelo.EmpresaColaboradora_BD();
            Controlador.EmpresaColaboradora clsEmpresaColaboradora = new Controlador.EmpresaColaboradora();

            if (txtRUC.Text.Length == 11)
            {
                if (clsEmpresaColaboradorabd.VerificarSiExisteRUC(txtRUC.Text) == true)
                {
                    //si existe actualizo datos de personal

                    clsEmpresaColaboradora.email = txtEmail.Text.Trim();
                    clsEmpresaColaboradora.gerente = txtGerente.Text.Trim();
                    clsEmpresaColaboradora.idEmpresaColaboradora = txtRUC.Text.Trim();
                    clsEmpresaColaboradora.nombreEmpresa = txtRazonSocial.Text.Trim();
                    clsEmpresaColaboradora.telefono = txtTelefono.Text.Trim();


                    int resultado = Modelo.EmpresaColaboradora_BD.ActualizarDatosdEmpresa(clsEmpresaColaboradora);
                    if (resultado > 0)
                    {
                        MessageBox.Show("La actualizacion se realizo con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar los datos de la empresa", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    // si no existe inserto el personal nuevo

                    clsEmpresaColaboradora.email = txtEmail.Text.Trim();
                    clsEmpresaColaboradora.gerente = txtGerente.Text.Trim();
                    clsEmpresaColaboradora.idEmpresaColaboradora = txtRUC.Text.Trim();
                    clsEmpresaColaboradora.nombreEmpresa = txtRazonSocial.Text.Trim();
                    clsEmpresaColaboradora.telefono = txtTelefono.Text.Trim();


                    int resultado = Modelo.EmpresaColaboradora_BD.AgregarEmpresa(clsEmpresaColaboradora);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Los datos de la empresa nueva se guardaron con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar los datos de la empresa", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            else
            {

                MessageBox.Show("Debe ingresar el RUC  de la empresa", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        void limpiarControles() {
            this.txtEmail.Text = null;
            this.txtGerente.Text = null;
            this.txtRazonSocial.Text = null;
            this.txtRUC.Text = null;
            this.txtTelefono.Text = null;
        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void txtRUC_Validating(object sender, CancelEventArgs e)
        {
            if (txtRUC.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.txtRUC, "Ingrese el RUC de la empresa"); 
            }
            else {
                this.errorProvider1.SetError(this.txtRUC, null);
            }
        }

        private void txtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (txtRazonSocial.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.txtRazonSocial, "Ingrese la Razon Social de la empresa");
            }
            else
            {
                this.errorProvider1.SetError(this.txtRazonSocial, null);
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Modelo.EmpresaColaboradora_BD clsEmpresaColaboradorabd = new Modelo.EmpresaColaboradora_BD();


                if (clsEmpresaColaboradorabd.VerificarSiExisteRUC(txtRUC.Text))
                {
                    //si existe el personal  recupero los datos de l personal a mis controles
                    Controlador.EmpresaColaboradora clsEmpresaColaboradora = new Controlador.EmpresaColaboradora();
                    //  Modelo.PersonalBD clspersonalbdx = new Modelo.PersonalBD();

                    clsEmpresaColaboradora.idEmpresaColaboradora = txtRUC.Text;


                    clsEmpresaColaboradora = clsEmpresaColaboradorabd.BuscarXRUC(clsEmpresaColaboradora);

                    this.txtEmail.Text = clsEmpresaColaboradora.email;
                    this.txtGerente.Text = clsEmpresaColaboradora.gerente;
                    this.txtRazonSocial.Text = clsEmpresaColaboradora.nombreEmpresa;
                    this.txtRUC.Text = clsEmpresaColaboradora.idEmpresaColaboradora;
                    this.txtTelefono.Text = clsEmpresaColaboradora.telefono;
                 
                               
                }
                else
                {

                    MessageBox.Show(" La empresa no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }



        }

        private void txtRUC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            txtRUC.Select();
            txtRUC.Focus();
        }
    }
}

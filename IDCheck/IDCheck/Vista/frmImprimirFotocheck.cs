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
    public partial class frmImprimirFotocheck : Form
    {
        public frmImprimirFotocheck(string dnitmp)
        {
            InitializeComponent();
            this.dni = dnitmp;
        }
        string dni;
        private void frmImprimirFotocheck_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSpersonal.personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.dSpersonal.personal,dni);

            this.reportViewer1.RefreshReport();
            //  MySqlDataAdapter adapter = new MySqlDataAdapter();

            // DataSet1 ds = new DataSet1();


            //   MySqlConnection cnx = Conexion.Conexion.ObtenerConexion();




            //  MySqlCommand comando = new MySqlCommand(string.Format("SELECT idPersonal, Nombres, Apellidos, Foto FROM personal where idPersonal = '{0}'", dni), cnx);


            //   adapter.SelectCommand = comando;

            //     adapter.Fill(ds.Tables[0]);

            //    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            //   reportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + @"\Report1.rdlc";

            //  MessageBox.Show(System.Environment.CurrentDirectory + @"\Report1.rdlc");

            //  reportViewer1.LocalReport.DataSources.Clear();




            // reportViewer1.LocalReport.DataSources.Add(Microsoft.Reporting.WinForms.ReportDataSource("DataSet1_DataTable1", ds.DataTable1));

            // reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1_DataTable1", ds.Tables[0]));

            //   reportViewer1.DocumentMapCollapsed = true;

            //  reportViewer1.RefreshReport();

            // this.reportViewer1.RefreshReport();
        }
    }
}

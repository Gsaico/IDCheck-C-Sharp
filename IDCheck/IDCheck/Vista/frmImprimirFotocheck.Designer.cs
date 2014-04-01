namespace IDCheck.Vista
{
    partial class frmImprimirFotocheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSpersonal = new Dataset.DSpersonal();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new Dataset.DSpersonalTableAdapters.personalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSpersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSpersonas";
            reportDataSource1.Value = this.personalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IDCheck.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(905, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSpersonal
            // 
            this.dSpersonal.DataSetName = "DSpersonal";
            this.dSpersonal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "personal";
            this.personalBindingSource.DataSource = this.dSpersonal;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // frmImprimirFotocheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 675);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmImprimirFotocheck";
            this.Text = "frmImprimirFotocheck";
            this.Load += new System.EventHandler(this.frmImprimirFotocheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSpersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private Dataset.DSpersonal dSpersonal;
        private Dataset.DSpersonalTableAdapters.personalTableAdapter personalTableAdapter;
    }
}
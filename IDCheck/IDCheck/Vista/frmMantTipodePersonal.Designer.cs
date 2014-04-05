namespace IDCheck.Vista
{
    partial class frmMantTipodePersonal
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTipoPersonal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTipoPersonal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTipoPersonal
            // 
            this.txtTipoPersonal.Location = new System.Drawing.Point(108, 14);
            this.txtTipoPersonal.MaxLength = 50;
            this.txtTipoPersonal.Name = "txtTipoPersonal";
            this.txtTipoPersonal.Size = new System.Drawing.Size(217, 20);
            this.txtTipoPersonal.TabIndex = 1;
           // this.txtTipoPersonal.TextChanged += new System.EventHandler(this.txtTipoPersonal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Personal:";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTipoPersonal
            // 
            this.dataGridViewTipoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipoPersonal.Location = new System.Drawing.Point(15, 61);
            this.dataGridViewTipoPersonal.Name = "dataGridViewTipoPersonal";
            this.dataGridViewTipoPersonal.Size = new System.Drawing.Size(391, 289);
            this.dataGridViewTipoPersonal.TabIndex = 3;
          //  this.dataGridViewTipoPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipoPersonal_CellContentClick);
            // 
            // frmMantTipodePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 375);
            this.Controls.Add(this.dataGridViewTipoPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoPersonal);
            this.Controls.Add(this.button1);
            this.Name = "frmMantTipodePersonal";
            this.Text = "frmMantTipodePersonal";
            this.Load += new System.EventHandler(this.frmMantTipodePersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTipoPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTipoPersonal;
    }
}
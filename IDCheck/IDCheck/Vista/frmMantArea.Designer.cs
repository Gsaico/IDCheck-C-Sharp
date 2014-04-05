namespace IDCheck.Vista
{
    partial class frmMantArea
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
            this.dataGridViewArea = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArea
            // 
            this.dataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArea.Location = new System.Drawing.Point(14, 79);
            this.dataGridViewArea.Name = "dataGridViewArea";
            this.dataGridViewArea.Size = new System.Drawing.Size(391, 289);
            this.dataGridViewArea.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Area:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(107, 32);
            this.txtArea.MaxLength = 50;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(217, 20);
            this.txtArea.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(330, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMantArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 397);
            this.Controls.Add(this.dataGridViewArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmMantArea";
            this.Text = "frmMantArea";
            this.Load += new System.EventHandler(this.frmMantArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnAgregar;
    }
}
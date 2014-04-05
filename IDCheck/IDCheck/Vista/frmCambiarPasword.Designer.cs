namespace IDCheck.Vista
{
    partial class frmCambiarPasword
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 76);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(118, 12);
            this.txtActual.MaxLength = 8;
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.Size = new System.Drawing.Size(100, 20);
            this.txtActual.TabIndex = 1;
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(118, 44);
            this.txtNueva.MaxLength = 8;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(100, 20);
            this.txtNueva.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña Actual:";
            // 
            // frmCambiarPasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 114);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmCambiarPasword";
            this.Text = "frmCambiarPasword";
            this.Load += new System.EventHandler(this.frmCambiarPasword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
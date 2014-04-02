namespace IDCheck.Vista
{
    partial class frmRegistrodePersonal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblTipoPersonal = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEncenderrojo = new System.Windows.Forms.Button();
            this.btnApagarRojo = new System.Windows.Forms.Button();
            this.btnApagarverde = new System.Windows.Forms.Button();
            this.btnEncenderverde = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.lblAcceso);
            this.groupBox2.Controls.Add(this.lblApellidos);
            this.groupBox2.Controls.Add(this.lblNombres);
            this.groupBox2.Controls.Add(this.lblNombreEmpresa);
            this.groupBox2.Controls.Add(this.lblDNI);
            this.groupBox2.Controls.Add(this.lblTipoPersonal);
            this.groupBox2.Controls.Add(this.picFoto);
            this.groupBox2.Location = new System.Drawing.Point(630, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 774);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblAcceso
            // 
            this.lblAcceso.AccessibleName = "lblAcceso";
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAcceso.Location = new System.Drawing.Point(6, 741);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(19, 20);
            this.lblAcceso.TabIndex = 12;
            this.lblAcceso.Text = "?";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellidos.Location = new System.Drawing.Point(6, 596);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(82, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombres.Location = new System.Drawing.Point(6, 557);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(80, 20);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AccessibleName = "lblEmpresa";
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(6, 669);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(80, 20);
            this.lblNombreEmpresa.TabIndex = 4;
            this.lblNombreEmpresa.Text = "Empresa";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDNI.Location = new System.Drawing.Point(6, 633);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 20);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // lblTipoPersonal
            // 
            this.lblTipoPersonal.AccessibleName = "lblTipodePersonal";
            this.lblTipoPersonal.AutoSize = true;
            this.lblTipoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPersonal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoPersonal.Location = new System.Drawing.Point(6, 705);
            this.lblTipoPersonal.Name = "lblTipoPersonal";
            this.lblTipoPersonal.Size = new System.Drawing.Size(143, 20);
            this.lblTipoPersonal.TabIndex = 6;
            this.lblTipoPersonal.Text = "Tipo de Personal";
            // 
            // picFoto
            // 
            this.picFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(6, 16);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(429, 497);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 11;
            this.picFoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnEncenderrojo);
            this.groupBox1.Controls.Add(this.btnApagarRojo);
            this.groupBox1.Controls.Add(this.btnApagarverde);
            this.groupBox1.Controls.Add(this.btnEncenderverde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 774);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(29, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Verde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(29, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rojo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 413);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnEncenderrojo
            // 
            this.btnEncenderrojo.Location = new System.Drawing.Point(33, 540);
            this.btnEncenderrojo.Name = "btnEncenderrojo";
            this.btnEncenderrojo.Size = new System.Drawing.Size(75, 23);
            this.btnEncenderrojo.TabIndex = 7;
            this.btnEncenderrojo.Text = "Encender";
            this.btnEncenderrojo.UseVisualStyleBackColor = true;
            this.btnEncenderrojo.Click += new System.EventHandler(this.btnEncenderrojo_Click);
            // 
            // btnApagarRojo
            // 
            this.btnApagarRojo.Location = new System.Drawing.Point(114, 540);
            this.btnApagarRojo.Name = "btnApagarRojo";
            this.btnApagarRojo.Size = new System.Drawing.Size(75, 23);
            this.btnApagarRojo.TabIndex = 8;
            this.btnApagarRojo.Text = "Apagar";
            this.btnApagarRojo.UseVisualStyleBackColor = true;
            this.btnApagarRojo.Click += new System.EventHandler(this.btnApagarRojo_Click);
            // 
            // btnApagarverde
            // 
            this.btnApagarverde.Location = new System.Drawing.Point(114, 608);
            this.btnApagarverde.Name = "btnApagarverde";
            this.btnApagarverde.Size = new System.Drawing.Size(75, 23);
            this.btnApagarverde.TabIndex = 9;
            this.btnApagarverde.Text = "Apagar";
            this.btnApagarverde.UseVisualStyleBackColor = true;
            this.btnApagarverde.Click += new System.EventHandler(this.btnApagarverde_Click);
            // 
            // btnEncenderverde
            // 
            this.btnEncenderverde.Location = new System.Drawing.Point(33, 608);
            this.btnEncenderverde.Name = "btnEncenderverde";
            this.btnEncenderverde.Size = new System.Drawing.Size(75, 23);
            this.btnEncenderverde.TabIndex = 10;
            this.btnEncenderverde.Text = "Encender";
            this.btnEncenderverde.UseVisualStyleBackColor = true;
            this.btnEncenderverde.Click += new System.EventHandler(this.btnEncenderverde_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(6, 519);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(429, 20);
            this.txtDNI.TabIndex = 14;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // frmRegistrodePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 801);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrodePersonal";
            this.Text = "frmRegistrodePersonal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistrodePersonal_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistrodePersonal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTipoPersonal;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEncenderrojo;
        private System.Windows.Forms.Button btnApagarRojo;
        private System.Windows.Forms.Button btnApagarverde;
        private System.Windows.Forms.Button btnEncenderverde;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
    }
}
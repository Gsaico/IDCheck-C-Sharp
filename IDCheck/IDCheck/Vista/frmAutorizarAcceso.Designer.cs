namespace IDCheck.Vista
{
    partial class frmAutorizarAcceso
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNota = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxONP = new System.Windows.Forms.CheckBox();
            this.cbxAFP = new System.Windows.Forms.CheckBox();
            this.cbdPDTplame = new System.Windows.Forms.CheckBox();
            this.cbxSCTRpensiones = new System.Windows.Forms.CheckBox();
            this.cbxSCTRsalud = new System.Windows.Forms.CheckBox();
            this.cbxEssalud = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmdTipoPersonal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblRUC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::IDCheck.Properties.Resources.document_save_as;
            this.btnGuardar.Location = new System.Drawing.Point(10, 645);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(41, 34);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Image = global::IDCheck.Properties.Resources.add;
            this.btnNuevo.Location = new System.Drawing.Point(58, 645);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(41, 34);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picFoto);
            this.groupBox4.Location = new System.Drawing.Point(436, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 622);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Foto";
            // 
            // picFoto
            // 
            this.picFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(6, 20);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(398, 596);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 2;
            this.picFoto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNota);
            this.groupBox3.Location = new System.Drawing.Point(12, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 168);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(16, 19);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(383, 133);
            this.txtNota.TabIndex = 13;
            this.txtNota.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbxONP);
            this.groupBox2.Controls.Add(this.cbxAFP);
            this.groupBox2.Controls.Add(this.cbdPDTplame);
            this.groupBox2.Controls.Add(this.cbxSCTRpensiones);
            this.groupBox2.Controls.Add(this.cbxSCTRsalud);
            this.groupBox2.Controls.Add(this.cbxEssalud);
            this.groupBox2.Location = new System.Drawing.Point(13, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 174);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisitos";
            // 
            // cbxONP
            // 
            this.cbxONP.AutoSize = true;
            this.cbxONP.Location = new System.Drawing.Point(15, 141);
            this.cbxONP.Name = "cbxONP";
            this.cbxONP.Size = new System.Drawing.Size(49, 17);
            this.cbxONP.TabIndex = 12;
            this.cbxONP.Text = "ONP";
            this.cbxONP.UseVisualStyleBackColor = true;
            // 
            // cbxAFP
            // 
            this.cbxAFP.AutoSize = true;
            this.cbxAFP.Location = new System.Drawing.Point(15, 118);
            this.cbxAFP.Name = "cbxAFP";
            this.cbxAFP.Size = new System.Drawing.Size(46, 17);
            this.cbxAFP.TabIndex = 11;
            this.cbxAFP.Text = "AFP";
            this.cbxAFP.UseVisualStyleBackColor = true;
            // 
            // cbdPDTplame
            // 
            this.cbdPDTplame.AutoSize = true;
            this.cbdPDTplame.Location = new System.Drawing.Point(15, 95);
            this.cbdPDTplame.Name = "cbdPDTplame";
            this.cbdPDTplame.Size = new System.Drawing.Size(80, 17);
            this.cbdPDTplame.TabIndex = 10;
            this.cbdPDTplame.Text = "PDT Plame";
            this.cbdPDTplame.UseVisualStyleBackColor = true;
            // 
            // cbxSCTRpensiones
            // 
            this.cbxSCTRpensiones.AutoSize = true;
            this.cbxSCTRpensiones.Location = new System.Drawing.Point(15, 72);
            this.cbxSCTRpensiones.Name = "cbxSCTRpensiones";
            this.cbxSCTRpensiones.Size = new System.Drawing.Size(107, 17);
            this.cbxSCTRpensiones.TabIndex = 9;
            this.cbxSCTRpensiones.Text = "SCTR Pensiones";
            this.cbxSCTRpensiones.UseVisualStyleBackColor = true;
            // 
            // cbxSCTRsalud
            // 
            this.cbxSCTRsalud.AutoSize = true;
            this.cbxSCTRsalud.Location = new System.Drawing.Point(15, 49);
            this.cbxSCTRsalud.Name = "cbxSCTRsalud";
            this.cbxSCTRsalud.Size = new System.Drawing.Size(85, 17);
            this.cbxSCTRsalud.TabIndex = 8;
            this.cbxSCTRsalud.Text = "SCTR Salud";
            this.cbxSCTRsalud.UseVisualStyleBackColor = true;
            // 
            // cbxEssalud
            // 
            this.cbxEssalud.AutoSize = true;
            this.cbxEssalud.Location = new System.Drawing.Point(15, 26);
            this.cbxEssalud.Name = "cbxEssalud";
            this.cbxEssalud.Size = new System.Drawing.Size(63, 17);
            this.cbxEssalud.TabIndex = 7;
            this.cbxEssalud.Text = "Essalud";
            this.cbxEssalud.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.cmbArea);
            this.groupBox1.Controls.Add(this.cmdTipoPersonal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.lblRUC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 248);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(90, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 13);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "0000/00/00";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(93, 148);
            this.txtRUC.Mask = "99999999999";
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(79, 20);
            this.txtRUC.TabIndex = 4;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(93, 57);
            this.txtDNI.Mask = "99999999";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(65, 20);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.dtpDesde.Location = new System.Drawing.Point(93, 89);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.dtpHasta.Location = new System.Drawing.Point(93, 119);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(93, 177);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(305, 21);
            this.cmbArea.TabIndex = 5;
            // 
            // cmdTipoPersonal
            // 
            this.cmdTipoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTipoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdTipoPersonal.FormattingEnabled = true;
            this.cmdTipoPersonal.Location = new System.Drawing.Point(93, 207);
            this.cmdTipoPersonal.Name = "cmdTipoPersonal";
            this.cmdTipoPersonal.Size = new System.Drawing.Size(305, 21);
            this.cmdTipoPersonal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ruc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Area:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Personal:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDNI.Location = new System.Drawing.Point(164, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(19, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "...";
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRUC.Location = new System.Drawing.Point(178, 155);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(19, 13);
            this.lblRUC.TabIndex = 7;
            this.lblRUC.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmAutorizarAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(855, 691);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAutorizarAcceso";
            this.Text = "frmAutorizarAcceso";
            this.Load += new System.EventHandler(this.frmAutorizarAcceso_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxONP;
        private System.Windows.Forms.CheckBox cbxAFP;
        private System.Windows.Forms.CheckBox cbdPDTplame;
        private System.Windows.Forms.CheckBox cbxSCTRpensiones;
        private System.Windows.Forms.CheckBox cbxSCTRsalud;
        private System.Windows.Forms.CheckBox cbxEssalud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmdTipoPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.MaskedTextBox txtRUC;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button1;
    }
}
﻿namespace IDCheck.Vista
{
    partial class IDCheck
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizarAccesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.accesoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarPersonalToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // actualizarPersonalToolStripMenuItem
            // 
            this.actualizarPersonalToolStripMenuItem.Name = "actualizarPersonalToolStripMenuItem";
            this.actualizarPersonalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.actualizarPersonalToolStripMenuItem.Text = "Actualizar Personal";
            this.actualizarPersonalToolStripMenuItem.Click += new System.EventHandler(this.actualizarPersonalToolStripMenuItem_Click);
            // 
            // accesoToolStripMenuItem
            // 
            this.accesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizarAccesoToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.accesoToolStripMenuItem.Name = "accesoToolStripMenuItem";
            this.accesoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.accesoToolStripMenuItem.Text = "Acceso";
            // 
            // autorizarAccesoToolStripMenuItem
            // 
            this.autorizarAccesoToolStripMenuItem.Name = "autorizarAccesoToolStripMenuItem";
            this.autorizarAccesoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.autorizarAccesoToolStripMenuItem.Text = "Autorizar Acceso";
            this.autorizarAccesoToolStripMenuItem.Click += new System.EventHandler(this.autorizarAccesoToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registroToolStripMenuItem.Text = "Registro de Personal";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // IDCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 742);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IDCheck";
            this.Text = "IDCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizarAccesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
    }
}
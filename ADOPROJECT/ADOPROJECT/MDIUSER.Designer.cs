﻿
namespace ADOPROJECT
{
    partial class MDIUSER
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
            this.vIEWPRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWMODELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWPRODUCTToolStripMenuItem,
            this.vIEWMODELToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vIEWPRODUCTToolStripMenuItem
            // 
            this.vIEWPRODUCTToolStripMenuItem.Name = "vIEWPRODUCTToolStripMenuItem";
            this.vIEWPRODUCTToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.vIEWPRODUCTToolStripMenuItem.Text = "VIEW PRODUCT";
            this.vIEWPRODUCTToolStripMenuItem.Click += new System.EventHandler(this.vIEWPRODUCTToolStripMenuItem_Click);
            // 
            // vIEWMODELToolStripMenuItem
            // 
            this.vIEWMODELToolStripMenuItem.Name = "vIEWMODELToolStripMenuItem";
            this.vIEWMODELToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.vIEWMODELToolStripMenuItem.Text = "VIEW MODEL";
            this.vIEWMODELToolStripMenuItem.Click += new System.EventHandler(this.vIEWMODELToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // MDIUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIUSER";
            this.Text = "MDIUSER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWPRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWMODELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}
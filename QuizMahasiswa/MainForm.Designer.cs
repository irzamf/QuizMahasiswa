﻿namespace QuizMahasiswa
{
    partial class MainForm
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
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterBarangToolStripMenuItem,
            this.reportBarangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterBarangToolStripMenuItem
            // 
            this.masterBarangToolStripMenuItem.Name = "masterBarangToolStripMenuItem";
            this.masterBarangToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.masterBarangToolStripMenuItem.Text = "Master Barang";
            this.masterBarangToolStripMenuItem.Click += new System.EventHandler(this.masterBarangToolStripMenuItem_Click);
            // 
            // reportBarangToolStripMenuItem
            // 
            this.reportBarangToolStripMenuItem.Name = "reportBarangToolStripMenuItem";
            this.reportBarangToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.reportBarangToolStripMenuItem.Text = "Report Barang";
            this.reportBarangToolStripMenuItem.Click += new System.EventHandler(this.reportBarangToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBarangToolStripMenuItem;
    }
}
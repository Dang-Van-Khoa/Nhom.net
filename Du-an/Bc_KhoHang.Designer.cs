﻿
namespace Du_an
{
    partial class Bc_KhoHang
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
            this.CRVTonKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVTonKho
            // 
            this.CRVTonKho.ActiveViewIndex = -1;
            this.CRVTonKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVTonKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVTonKho.Location = new System.Drawing.Point(0, 0);
            this.CRVTonKho.Name = "CRVTonKho";
            this.CRVTonKho.Size = new System.Drawing.Size(800, 450);
            this.CRVTonKho.TabIndex = 0;
            // 
            // Bc_KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRVTonKho);
            this.Name = "Bc_KhoHang";
            this.Text = "Bc_KhoHang";
            this.Load += new System.EventHandler(this.Bc_KhoHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVTonKho;
    }
}
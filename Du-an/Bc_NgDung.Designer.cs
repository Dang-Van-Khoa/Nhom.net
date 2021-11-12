namespace Du_an
{
    partial class Bc_NgDung
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
            this.CRVNguoiDung = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVNguoiDung
            // 
            this.CRVNguoiDung.ActiveViewIndex = -1;
            this.CRVNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVNguoiDung.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.CRVNguoiDung.Name = "CRVNguoiDung";
            this.CRVNguoiDung.Size = new System.Drawing.Size(868, 261);
            this.CRVNguoiDung.TabIndex = 0;
            // 
            // Bc_NgDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 261);
            this.Controls.Add(this.CRVNguoiDung);
            this.Name = "Bc_NgDung";
            this.Text = "Bc_NgDung";
            this.Load += new System.EventHandler(this.Bc_NgDung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVNguoiDung;
    }
}
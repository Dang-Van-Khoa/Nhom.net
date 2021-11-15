namespace Du_an
{
    partial class Bc_GiaoDich
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
            this.CRVGiaoDich = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVGiaoDich
            // 
            this.CRVGiaoDich.ActiveViewIndex = -1;
            this.CRVGiaoDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVGiaoDich.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVGiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVGiaoDich.Location = new System.Drawing.Point(0, 0);
            this.CRVGiaoDich.Name = "CRVGiaoDich";
            this.CRVGiaoDich.Size = new System.Drawing.Size(649, 261);
            this.CRVGiaoDich.TabIndex = 0;
            // 
            // Bc_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 261);
            this.Controls.Add(this.CRVGiaoDich);
            this.Name = "Bc_GiaoDich";
            this.Text = "Bc_GiaoDich";
            this.Load += new System.EventHandler(this.Bc_GiaoDich_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVGiaoDich;
    }
}
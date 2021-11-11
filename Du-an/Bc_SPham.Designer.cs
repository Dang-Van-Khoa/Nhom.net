
namespace Du_an
{
    partial class Bc_SPham
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
            this.CRVSanPham = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVSanPham
            // 
            this.CRVSanPham.ActiveViewIndex = -1;
            this.CRVSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVSanPham.Location = new System.Drawing.Point(0, 0);
            this.CRVSanPham.Name = "CRVSanPham";
            this.CRVSanPham.Size = new System.Drawing.Size(800, 450);
            this.CRVSanPham.TabIndex = 0;
            // 
            // Bc_SPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRVSanPham);
            this.Name = "Bc_SPham";
            this.Text = "Báo cáo thông tin sản phẩm";
            this.Load += new System.EventHandler(this.Bc_SPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVSanPham;
    }
}
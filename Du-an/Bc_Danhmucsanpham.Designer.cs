
namespace Du_an
{
    partial class Bc_Danhmucsanpham
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
            this.CRV_Dmuc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_Dmuc
            // 
            this.CRV_Dmuc.ActiveViewIndex = -1;
            this.CRV_Dmuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_Dmuc.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_Dmuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_Dmuc.Location = new System.Drawing.Point(0, 0);
            this.CRV_Dmuc.Name = "CRV_Dmuc";
            this.CRV_Dmuc.Size = new System.Drawing.Size(800, 450);
            this.CRV_Dmuc.TabIndex = 0;
            // 
            // Bc_Danhmucsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRV_Dmuc);
            this.Name = "Bc_Danhmucsanpham";
            this.Text = "Bc_Danhmucsanpham";
            this.Load += new System.EventHandler(this.Bc_Danhmucsanpham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_Dmuc;
    }
}
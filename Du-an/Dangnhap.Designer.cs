namespace Du_an
{
    partial class Dangnhap
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
            this.dataGrid_Dangnhap = new System.Windows.Forms.DataGridView();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.txt_Taikhoan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lbl_Matkhau = new System.Windows.Forms.Label();
            this.lbl_Taikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Dangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Dangnhap
            // 
            this.dataGrid_Dangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Dangnhap.Location = new System.Drawing.Point(151, 275);
            this.dataGrid_Dangnhap.Name = "dataGrid_Dangnhap";
            this.dataGrid_Dangnhap.RowHeadersWidth = 51;
            this.dataGrid_Dangnhap.RowTemplate.Height = 24;
            this.dataGrid_Dangnhap.Size = new System.Drawing.Size(397, 150);
            this.dataGrid_Dangnhap.TabIndex = 12;
            this.dataGrid_Dangnhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Dangnhap_CellContentClick);
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matkhau.Location = new System.Drawing.Point(215, 169);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Size = new System.Drawing.Size(293, 34);
            this.txt_Matkhau.TabIndex = 10;
            // 
            // txt_Taikhoan
            // 
            this.txt_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Taikhoan.Location = new System.Drawing.Point(215, 92);
            this.txt_Taikhoan.Name = "txt_Taikhoan";
            this.txt_Taikhoan.Size = new System.Drawing.Size(293, 34);
            this.txt_Taikhoan.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(608, 167);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 43);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(590, 88);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(154, 43);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lbl_Matkhau
            // 
            this.lbl_Matkhau.AutoSize = true;
            this.lbl_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matkhau.Location = new System.Drawing.Point(56, 174);
            this.lbl_Matkhau.Name = "lbl_Matkhau";
            this.lbl_Matkhau.Size = new System.Drawing.Size(109, 29);
            this.lbl_Matkhau.TabIndex = 4;
            this.lbl_Matkhau.Text = "Mật khẩu";
            // 
            // lbl_Taikhoan
            // 
            this.lbl_Taikhoan.AutoSize = true;
            this.lbl_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Taikhoan.Location = new System.Drawing.Point(56, 97);
            this.lbl_Taikhoan.Name = "lbl_Taikhoan";
            this.lbl_Taikhoan.Size = new System.Drawing.Size(119, 29);
            this.lbl_Taikhoan.TabIndex = 5;
            this.lbl_Taikhoan.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đăng Nhập";
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_Dangnhap);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.txt_Taikhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lbl_Matkhau);
            this.Controls.Add(this.lbl_Taikhoan);
            this.Controls.Add(this.label1);
            this.Name = "Dangnhap";
            this.Text = "Dangnhap";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Dangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Dangnhap;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.TextBox txt_Taikhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lbl_Matkhau;
        private System.Windows.Forms.Label lbl_Taikhoan;
        private System.Windows.Forms.Label label1;
    }
}
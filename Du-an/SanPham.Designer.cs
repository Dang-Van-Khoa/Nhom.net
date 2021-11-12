
namespace Du_an
{
    partial class SanPham
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
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtLuotXem = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.DataGrid_SanPham = new System.Windows.Forms.DataGridView();
            this.lblLuotXem = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.cboManhacc = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblManhacc = new System.Windows.Forms.Label();
            this.txtId_SanPham = new System.Windows.Forms.TextBox();
            this.lblId_SanPham = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(64, 22);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(204, 186);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 167;
            this.picAnh.TabStop = false;
            // 
            // txtLuotXem
            // 
            this.txtLuotXem.AutoSize = true;
            this.txtLuotXem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuotXem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLuotXem.Location = new System.Drawing.Point(205, 479);
            this.txtLuotXem.Name = "txtLuotXem";
            this.txtLuotXem.Size = new System.Drawing.Size(90, 22);
            this.txtLuotXem.TabIndex = 166;
            this.txtLuotXem.Text = "................";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnTaoMoi.Location = new System.Drawing.Point(812, 134);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(99, 46);
            this.btnTaoMoi.TabIndex = 165;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.Blue;
            this.btnChonAnh.Location = new System.Drawing.Point(305, 82);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(103, 33);
            this.btnChonAnh.TabIndex = 159;
            this.btnChonAnh.Text = "&Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // DataGrid_SanPham
            // 
            this.DataGrid_SanPham.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_SanPham.Location = new System.Drawing.Point(64, 513);
            this.DataGrid_SanPham.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_SanPham.Name = "DataGrid_SanPham";
            this.DataGrid_SanPham.RowTemplate.Height = 28;
            this.DataGrid_SanPham.Size = new System.Drawing.Size(847, 186);
            this.DataGrid_SanPham.TabIndex = 161;
            this.DataGrid_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_SanPham_CellClick);
            // 
            // lblLuotXem
            // 
            this.lblLuotXem.AutoSize = true;
            this.lblLuotXem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuotXem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLuotXem.Location = new System.Drawing.Point(60, 480);
            this.lblLuotXem.Name = "lblLuotXem";
            this.lblLuotXem.Size = new System.Drawing.Size(97, 22);
            this.lblLuotXem.TabIndex = 158;
            this.lblLuotXem.Text = "Lượt Xem:";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayTao.Location = new System.Drawing.Point(209, 439);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(550, 29);
            this.txtNgayTao.TabIndex = 157;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgayTao.Location = new System.Drawing.Point(60, 439);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(101, 22);
            this.lblNgayTao.TabIndex = 156;
            this.lblNgayTao.Text = "Ngày Tạo: ";
            // 
            // cboManhacc
            // 
            this.cboManhacc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManhacc.FormattingEnabled = true;
            this.cboManhacc.Location = new System.Drawing.Point(209, 214);
            this.cboManhacc.Name = "cboManhacc";
            this.cboManhacc.Size = new System.Drawing.Size(550, 30);
            this.cboManhacc.TabIndex = 155;
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(209, 252);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(550, 29);
            this.txtTen.TabIndex = 153;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTen.Location = new System.Drawing.Point(60, 251);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(135, 22);
            this.lblTen.TabIndex = 152;
            this.lblTen.Text = "Tên Sản Phẩm:";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.Color.Blue;
            this.lblSanPham.Location = new System.Drawing.Point(346, 10);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(278, 26);
            this.lblSanPham.TabIndex = 149;
            this.lblSanPham.Text = "DANH MỤC SẢN PHẨM";
            // 
            // lblManhacc
            // 
            this.lblManhacc.AutoSize = true;
            this.lblManhacc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManhacc.Location = new System.Drawing.Point(62, 214);
            this.lblManhacc.Name = "lblManhacc";
            this.lblManhacc.Size = new System.Drawing.Size(95, 22);
            this.lblManhacc.TabIndex = 148;
            this.lblManhacc.Text = "Mã NCC: ";
            // 
            // txtId_SanPham
            // 
            this.txtId_SanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtId_SanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_SanPham.Location = new System.Drawing.Point(437, 140);
            this.txtId_SanPham.Name = "txtId_SanPham";
            this.txtId_SanPham.Size = new System.Drawing.Size(322, 29);
            this.txtId_SanPham.TabIndex = 147;
            // 
            // lblId_SanPham
            // 
            this.lblId_SanPham.AutoSize = true;
            this.lblId_SanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_SanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblId_SanPham.Location = new System.Drawing.Point(301, 140);
            this.lblId_SanPham.Name = "lblId_SanPham";
            this.lblId_SanPham.Size = new System.Drawing.Size(124, 22);
            this.lblId_SanPham.TabIndex = 146;
            this.lblId_SanPham.Text = "ID Sản Phẩm:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(812, 424);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 46);
            this.btnThoat.TabIndex = 145;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(812, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 46);
            this.btnXoa.TabIndex = 144;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Location = new System.Drawing.Point(812, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 46);
            this.btnSua.TabIndex = 143;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(812, 205);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 46);
            this.btnLuu.TabIndex = 142;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(209, 401);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(549, 29);
            this.txtGiamGia.TabIndex = 173;
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(209, 328);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(549, 65);
            this.txtNoiDung.TabIndex = 172;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(209, 291);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(549, 29);
            this.txtGia.TabIndex = 171;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGia.Location = new System.Drawing.Point(60, 290);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(45, 22);
            this.lblGia.TabIndex = 170;
            this.lblGia.Text = "Giá:";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGiamGia.Location = new System.Drawing.Point(60, 400);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(95, 22);
            this.lblGiamGia.TabIndex = 169;
            this.lblGiamGia.Text = "Giảm Giá:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNoiDung.Location = new System.Drawing.Point(60, 345);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(93, 22);
            this.lblNoiDung.TabIndex = 168;
            this.lblNoiDung.Text = "Nội Dung:";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 710);
            this.ControlBox = false;
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.txtLuotXem);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.DataGrid_SanPham);
            this.Controls.Add(this.lblLuotXem);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.cboManhacc);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.lblManhacc);
            this.Controls.Add(this.txtId_SanPham);
            this.Controls.Add(this.lblId_SanPham);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label txtLuotXem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.DataGridView DataGrid_SanPham;
        private System.Windows.Forms.Label lblLuotXem;
        private System.Windows.Forms.DateTimePicker txtNgayTao;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.ComboBox cboManhacc;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblManhacc;
        private System.Windows.Forms.TextBox txtId_SanPham;
        private System.Windows.Forms.Label lblId_SanPham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblNoiDung;
    }
}
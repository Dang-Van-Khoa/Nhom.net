namespace Du_an
{
    partial class GiaoDich
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
            this.lblGiaoDich = new System.Windows.Forms.Label();
            this.lblId_GiaoDich = new System.Windows.Forms.Label();
            this.txtId_GiaoDich = new System.Windows.Forms.TextBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.NumericUpDown();
            this.lblId_NguoiDung = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtHinhThucTra = new System.Windows.Forms.TextBox();
            this.lblHinhThucTra = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.dataGrid_GiaoDich = new System.Windows.Forms.DataGridView();
            this.cboIdNguoiDung = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_GiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaoDich
            // 
            this.lblGiaoDich.AutoSize = true;
            this.lblGiaoDich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaoDich.ForeColor = System.Drawing.Color.Blue;
            this.lblGiaoDich.Location = new System.Drawing.Point(311, 20);
            this.lblGiaoDich.Name = "lblGiaoDich";
            this.lblGiaoDich.Size = new System.Drawing.Size(174, 26);
            this.lblGiaoDich.TabIndex = 93;
            this.lblGiaoDich.Text = "Bảng Giao Dịch";
            // 
            // lblId_GiaoDich
            // 
            this.lblId_GiaoDich.AutoSize = true;
            this.lblId_GiaoDich.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_GiaoDich.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblId_GiaoDich.Location = new System.Drawing.Point(33, 72);
            this.lblId_GiaoDich.Name = "lblId_GiaoDich";
            this.lblId_GiaoDich.Size = new System.Drawing.Size(124, 22);
            this.lblId_GiaoDich.TabIndex = 94;
            this.lblId_GiaoDich.Text = "ID Giao Dịch:";
            // 
            // txtId_GiaoDich
            // 
            this.txtId_GiaoDich.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtId_GiaoDich.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_GiaoDich.Location = new System.Drawing.Point(180, 72);
            this.txtId_GiaoDich.Name = "txtId_GiaoDich";
            this.txtId_GiaoDich.Size = new System.Drawing.Size(478, 29);
            this.txtId_GiaoDich.TabIndex = 95;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTrangThai.Location = new System.Drawing.Point(33, 110);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(108, 22);
            this.lbTrangThai.TabIndex = 96;
            this.lbTrangThai.Text = "Trạng Thái:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(180, 109);
            this.txtTrangThai.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(478, 29);
            this.txtTrangThai.TabIndex = 130;
            // 
            // lblId_NguoiDung
            // 
            this.lblId_NguoiDung.AutoSize = true;
            this.lblId_NguoiDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_NguoiDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblId_NguoiDung.Location = new System.Drawing.Point(33, 152);
            this.lblId_NguoiDung.Name = "lblId_NguoiDung";
            this.lblId_NguoiDung.Size = new System.Drawing.Size(141, 22);
            this.lblId_NguoiDung.TabIndex = 131;
            this.lblId_NguoiDung.Text = "ID Người Dùng:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(180, 264);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(478, 29);
            this.txtDienThoai.TabIndex = 138;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDienThoai.Location = new System.Drawing.Point(33, 264);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(132, 22);
            this.lblDienThoai.TabIndex = 137;
            this.lblDienThoai.Text = "Số Điện Thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(180, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(478, 29);
            this.txtEmail.TabIndex = 136;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(33, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 135;
            this.lblEmail.Text = "Email:";
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(180, 187);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(478, 29);
            this.txtTen.TabIndex = 134;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTen.Location = new System.Drawing.Point(33, 187);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(76, 22);
            this.lblTen.TabIndex = 133;
            this.lblTen.Text = "Họ Tên:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(180, 306);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(478, 29);
            this.txtTongTien.TabIndex = 140;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTongTien.Location = new System.Drawing.Point(33, 306);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 22);
            this.lblTongTien.TabIndex = 139;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtHinhThucTra
            // 
            this.txtHinhThucTra.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHinhThucTra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhThucTra.Location = new System.Drawing.Point(180, 341);
            this.txtHinhThucTra.Name = "txtHinhThucTra";
            this.txtHinhThucTra.Size = new System.Drawing.Size(478, 29);
            this.txtHinhThucTra.TabIndex = 142;
            // 
            // lblHinhThucTra
            // 
            this.lblHinhThucTra.AutoSize = true;
            this.lblHinhThucTra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhThucTra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHinhThucTra.Location = new System.Drawing.Point(32, 344);
            this.lblHinhThucTra.Name = "lblHinhThucTra";
            this.lblHinhThucTra.Size = new System.Drawing.Size(142, 22);
            this.lblHinhThucTra.TabIndex = 141;
            this.lblHinhThucTra.Text = "Hình Thức Trải:";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgayTao.Location = new System.Drawing.Point(33, 385);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(96, 22);
            this.lblNgayTao.TabIndex = 143;
            this.lblNgayTao.Text = "Ngày Tạo:";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayTao.Location = new System.Drawing.Point(180, 378);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(478, 29);
            this.txtNgayTao.TabIndex = 144;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(679, 341);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 47);
            this.btnThoat.TabIndex = 150;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(679, 277);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 47);
            this.btnXoa.TabIndex = 149;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Location = new System.Drawing.Point(679, 210);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 47);
            this.btnSua.TabIndex = 148;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(679, 143);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 47);
            this.btnLuu.TabIndex = 147;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnTaoMoi.Location = new System.Drawing.Point(679, 76);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(128, 47);
            this.btnTaoMoi.TabIndex = 146;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // dataGrid_GiaoDich
            // 
            this.dataGrid_GiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_GiaoDich.Location = new System.Drawing.Point(37, 378);
            this.dataGrid_GiaoDich.Name = "dataGrid_GiaoDich";
            this.dataGrid_GiaoDich.Size = new System.Drawing.Size(711, 150);
            this.dataGrid_GiaoDich.TabIndex = 151;
            // 
            // cboIdNguoiDung
            // 
            this.cboIdNguoiDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIdNguoiDung.FormattingEnabled = true;
            this.cboIdNguoiDung.Location = new System.Drawing.Point(180, 149);
            this.cboIdNguoiDung.Name = "cboIdNguoiDung";
            this.cboIdNguoiDung.Size = new System.Drawing.Size(478, 30);
            this.cboIdNguoiDung.TabIndex = 152;
            this.cboIdNguoiDung.SelectedIndexChanged += new System.EventHandler(this.cboIdNguoiDung_SelectedIndexChanged);
            // 
            // GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 509);
            this.Controls.Add(this.cboIdNguoiDung);
            this.Controls.Add(this.dataGrid_GiaoDich);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.txtHinhThucTra);
            this.Controls.Add(this.lblHinhThucTra);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblId_NguoiDung);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.txtId_GiaoDich);
            this.Controls.Add(this.lblId_GiaoDich);
            this.Controls.Add(this.lblGiaoDich);
            this.Name = "GiaoDich";
            this.Text = "GiaoDich";
            this.Load += new System.EventHandler(this.GiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_GiaoDich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiaoDich;
        private System.Windows.Forms.Label lblId_GiaoDich;
        private System.Windows.Forms.TextBox txtId_GiaoDich;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.NumericUpDown txtTrangThai;
        private System.Windows.Forms.Label lblId_NguoiDung;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtHinhThucTra;
        private System.Windows.Forms.Label lblHinhThucTra;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.DateTimePicker txtNgayTao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.DataGridView dataGrid_GiaoDich;
        private System.Windows.Forms.ComboBox cboIdNguoiDung;
    }
}
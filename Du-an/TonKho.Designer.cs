
namespace Du_an
{
    partial class TonKho
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
            this.DataGrid_TonKho = new System.Windows.Forms.DataGridView();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.lblId_SanPham = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblSlnhap = new System.Windows.Forms.Label();
            this.lblSldau = new System.Windows.Forms.Label();
            this.lblSlCuoi = new System.Windows.Forms.Label();
            this.lblSlxuat = new System.Windows.Forms.Label();
            this.cboId_SanPham = new System.Windows.Forms.ComboBox();
            this.txtSldau = new System.Windows.Forms.NumericUpDown();
            this.txtSlxuat = new System.Windows.Forms.NumericUpDown();
            this.txtSlnhap = new System.Windows.Forms.NumericUpDown();
            this.txtSlCuoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSldau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_TonKho
            // 
            this.DataGrid_TonKho.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_TonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TonKho.Location = new System.Drawing.Point(41, 317);
            this.DataGrid_TonKho.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_TonKho.Name = "DataGrid_TonKho";
            this.DataGrid_TonKho.RowTemplate.Height = 28;
            this.DataGrid_TonKho.Size = new System.Drawing.Size(655, 159);
            this.DataGrid_TonKho.TabIndex = 122;
            // 
            // lblTonKho
            // 
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonKho.ForeColor = System.Drawing.Color.Blue;
            this.lblTonKho.Location = new System.Drawing.Point(298, 9);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(287, 26);
            this.lblTonKho.TabIndex = 115;
            this.lblTonKho.Text = "THÔNG TIN KHO HÀNG";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(736, 317);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 46);
            this.btnThoat.TabIndex = 110;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(736, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 46);
            this.btnXoa.TabIndex = 109;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Location = new System.Drawing.Point(736, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 46);
            this.btnSua.TabIndex = 108;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(736, 116);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 46);
            this.btnLuu.TabIndex = 107;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnTaoMoi.Location = new System.Drawing.Point(736, 49);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(128, 46);
            this.btnTaoMoi.TabIndex = 106;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // lblId_SanPham
            // 
            this.lblId_SanPham.AutoSize = true;
            this.lblId_SanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_SanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblId_SanPham.Location = new System.Drawing.Point(37, 111);
            this.lblId_SanPham.Name = "lblId_SanPham";
            this.lblId_SanPham.Size = new System.Drawing.Size(124, 22);
            this.lblId_SanPham.TabIndex = 123;
            this.lblId_SanPham.Text = "ID Sản Phẩm:";
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgay.Location = new System.Drawing.Point(185, 73);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(510, 29);
            this.txtNgay.TabIndex = 126;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgay.Location = new System.Drawing.Point(37, 73);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(63, 22);
            this.lblNgay.TabIndex = 125;
            this.lblNgay.Text = "Ngày: ";
            // 
            // lblSlnhap
            // 
            this.lblSlnhap.AutoSize = true;
            this.lblSlnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSlnhap.Location = new System.Drawing.Point(37, 187);
            this.lblSlnhap.Name = "lblSlnhap";
            this.lblSlnhap.Size = new System.Drawing.Size(133, 22);
            this.lblSlnhap.TabIndex = 132;
            this.lblSlnhap.Text = "Số lượng nhập:";
            // 
            // lblSldau
            // 
            this.lblSldau.AutoSize = true;
            this.lblSldau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSldau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSldau.Location = new System.Drawing.Point(37, 149);
            this.lblSldau.Name = "lblSldau";
            this.lblSldau.Size = new System.Drawing.Size(123, 22);
            this.lblSldau.TabIndex = 130;
            this.lblSldau.Text = "Số lượng đầu:";
            // 
            // lblSlCuoi
            // 
            this.lblSlCuoi.AutoSize = true;
            this.lblSlCuoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlCuoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSlCuoi.Location = new System.Drawing.Point(37, 263);
            this.lblSlCuoi.Name = "lblSlCuoi";
            this.lblSlCuoi.Size = new System.Drawing.Size(127, 22);
            this.lblSlCuoi.TabIndex = 128;
            this.lblSlCuoi.Text = "Số lượng cuối:";
            // 
            // lblSlxuat
            // 
            this.lblSlxuat.AutoSize = true;
            this.lblSlxuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlxuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSlxuat.Location = new System.Drawing.Point(37, 225);
            this.lblSlxuat.Name = "lblSlxuat";
            this.lblSlxuat.Size = new System.Drawing.Size(128, 22);
            this.lblSlxuat.TabIndex = 127;
            this.lblSlxuat.Text = "Số lượng xuất:";
            // 
            // cboId_SanPham
            // 
            this.cboId_SanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboId_SanPham.FormattingEnabled = true;
            this.cboId_SanPham.Location = new System.Drawing.Point(186, 108);
            this.cboId_SanPham.Name = "cboId_SanPham";
            this.cboId_SanPham.Size = new System.Drawing.Size(511, 30);
            this.cboId_SanPham.TabIndex = 135;
            // 
            // txtSldau
            // 
            this.txtSldau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSldau.Location = new System.Drawing.Point(185, 148);
            this.txtSldau.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.txtSldau.Name = "txtSldau";
            this.txtSldau.Size = new System.Drawing.Size(510, 29);
            this.txtSldau.TabIndex = 136;
            // 
            // txtSlxuat
            // 
            this.txtSlxuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlxuat.Location = new System.Drawing.Point(185, 225);
            this.txtSlxuat.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.txtSlxuat.Name = "txtSlxuat";
            this.txtSlxuat.Size = new System.Drawing.Size(510, 29);
            this.txtSlxuat.TabIndex = 137;
            // 
            // txtSlnhap
            // 
            this.txtSlnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlnhap.Location = new System.Drawing.Point(185, 186);
            this.txtSlnhap.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.txtSlnhap.Name = "txtSlnhap";
            this.txtSlnhap.Size = new System.Drawing.Size(510, 29);
            this.txtSlnhap.TabIndex = 138;
            // 
            // txtSlCuoi
            // 
            this.txtSlCuoi.AutoSize = true;
            this.txtSlCuoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlCuoi.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtSlCuoi.Location = new System.Drawing.Point(182, 263);
            this.txtSlCuoi.Name = "txtSlCuoi";
            this.txtSlCuoi.Size = new System.Drawing.Size(115, 22);
            this.txtSlCuoi.TabIndex = 139;
            this.txtSlCuoi.Text = ".....................";
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 487);
            this.ControlBox = false;
            this.Controls.Add(this.txtSlCuoi);
            this.Controls.Add(this.txtSlnhap);
            this.Controls.Add(this.txtSlxuat);
            this.Controls.Add(this.txtSldau);
            this.Controls.Add(this.cboId_SanPham);
            this.Controls.Add(this.lblSlnhap);
            this.Controls.Add(this.lblSldau);
            this.Controls.Add(this.lblSlCuoi);
            this.Controls.Add(this.lblSlxuat);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblId_SanPham);
            this.Controls.Add(this.DataGrid_TonKho);
            this.Controls.Add(this.lblTonKho);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoMoi);
            this.Name = "TonKho";
            this.Text = "TonKho";
            this.Load += new System.EventHandler(this.TonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSldau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_TonKho;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label lblId_SanPham;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblSlnhap;
        private System.Windows.Forms.Label lblSldau;
        private System.Windows.Forms.Label lblSlCuoi;
        private System.Windows.Forms.Label lblSlxuat;
        private System.Windows.Forms.ComboBox cboId_SanPham;
        private System.Windows.Forms.NumericUpDown txtSldau;
        private System.Windows.Forms.NumericUpDown txtSlxuat;
        private System.Windows.Forms.NumericUpDown txtSlnhap;
        private System.Windows.Forms.Label txtSlCuoi;
    }
}
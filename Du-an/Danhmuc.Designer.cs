namespace Du_an
{
    partial class Danhmuc
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_Mota = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.dataGrid_Danhmuc = new System.Windows.Forms.DataGridView();
            this.txt_IDsanpham = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bntTaomoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Danhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(385, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Danh mục";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(12, 116);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(157, 29);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID_Sản phẩm";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.Location = new System.Drawing.Point(12, 193);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(172, 29);
            this.lbl_Ten.TabIndex = 1;
            this.lbl_Ten.Text = "Tên sản phẩm ";
            // 
            // lbl_Mota
            // 
            this.lbl_Mota.AutoSize = true;
            this.lbl_Mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mota.Location = new System.Drawing.Point(12, 274);
            this.lbl_Mota.Name = "lbl_Mota";
            this.lbl_Mota.Size = new System.Drawing.Size(182, 29);
            this.lbl_Mota.TabIndex = 1;
            this.lbl_Mota.Text = "Mô tả sản phẩm";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(246, 188);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(297, 34);
            this.txt_Ten.TabIndex = 3;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(246, 269);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(297, 34);
            this.txt_MoTa.TabIndex = 3;
            // 
            // dataGrid_Danhmuc
            // 
            this.dataGrid_Danhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Danhmuc.Location = new System.Drawing.Point(159, 364);
            this.dataGrid_Danhmuc.Name = "dataGrid_Danhmuc";
            this.dataGrid_Danhmuc.RowHeadersWidth = 51;
            this.dataGrid_Danhmuc.RowTemplate.Height = 24;
            this.dataGrid_Danhmuc.Size = new System.Drawing.Size(455, 177);
            this.dataGrid_Danhmuc.TabIndex = 4;
            this.dataGrid_Danhmuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Danhmuc_CellContentClick);
            // 
            // txt_IDsanpham
            // 
            this.txt_IDsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDsanpham.Location = new System.Drawing.Point(246, 113);
            this.txt_IDsanpham.Name = "txt_IDsanpham";
            this.txt_IDsanpham.Size = new System.Drawing.Size(297, 34);
            this.txt_IDsanpham.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(664, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 34);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(664, 132);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 34);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bntTaomoi
            // 
            this.bntTaomoi.Location = new System.Drawing.Point(664, 72);
            this.bntTaomoi.Name = "bntTaomoi";
            this.bntTaomoi.Size = new System.Drawing.Size(110, 34);
            this.bntTaomoi.TabIndex = 5;
            this.bntTaomoi.Text = "Tạo mới";
            this.bntTaomoi.UseVisualStyleBackColor = true;
            this.bntTaomoi.Click += new System.EventHandler(this.bntTaomoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(664, 192);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 34);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(664, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 34);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 593);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bntTaomoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGrid_Danhmuc);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_IDsanpham);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.lbl_Mota);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl1);
            this.Name = "Danhmuc";
            this.Text = "Danhmuc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Danhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_Mota;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.DataGridView dataGrid_Danhmuc;
        private System.Windows.Forms.TextBox txt_IDsanpham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button bntTaomoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}
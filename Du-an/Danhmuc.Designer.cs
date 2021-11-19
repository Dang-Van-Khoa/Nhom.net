
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
            this.btnSua = new System.Windows.Forms.Button();
            this.bntTaomoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGrid_Danhmuc = new System.Windows.Forms.DataGridView();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_IDsanpham = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.lbl_Mota = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Danhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(604, 153);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 28);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bntTaomoi
            // 
            this.bntTaomoi.Location = new System.Drawing.Point(604, 55);
            this.bntTaomoi.Margin = new System.Windows.Forms.Padding(2);
            this.bntTaomoi.Name = "bntTaomoi";
            this.bntTaomoi.Size = new System.Drawing.Size(82, 28);
            this.bntTaomoi.TabIndex = 15;
            this.bntTaomoi.Text = "Tạo mới";
            this.bntTaomoi.UseVisualStyleBackColor = true;
            this.bntTaomoi.Click += new System.EventHandler(this.bntTaomoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(604, 204);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 28);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(604, 104);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 28);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(604, 263);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 28);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGrid_Danhmuc
            // 
            this.dataGrid_Danhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Danhmuc.Location = new System.Drawing.Point(225, 293);
            this.dataGrid_Danhmuc.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_Danhmuc.Name = "dataGrid_Danhmuc";
            this.dataGrid_Danhmuc.RowHeadersWidth = 51;
            this.dataGrid_Danhmuc.RowTemplate.Height = 24;
            this.dataGrid_Danhmuc.Size = new System.Drawing.Size(341, 144);
            this.dataGrid_Danhmuc.TabIndex = 13;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(290, 216);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(224, 28);
            this.txt_MoTa.TabIndex = 10;
            // 
            // txt_IDsanpham
            // 
            this.txt_IDsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDsanpham.Location = new System.Drawing.Point(290, 89);
            this.txt_IDsanpham.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDsanpham.Name = "txt_IDsanpham";
            this.txt_IDsanpham.Size = new System.Drawing.Size(224, 28);
            this.txt_IDsanpham.TabIndex = 11;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(290, 150);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(224, 28);
            this.txt_Ten.TabIndex = 12;
            // 
            // lbl_Mota
            // 
            this.lbl_Mota.AutoSize = true;
            this.lbl_Mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mota.Location = new System.Drawing.Point(115, 220);
            this.lbl_Mota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mota.Name = "lbl_Mota";
            this.lbl_Mota.Size = new System.Drawing.Size(144, 24);
            this.lbl_Mota.TabIndex = 7;
            this.lbl_Mota.Text = "Mô tả sản phẩm";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.Location = new System.Drawing.Point(115, 154);
            this.lbl_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(137, 24);
            this.lbl_Ten.TabIndex = 8;
            this.lbl_Ten.Text = "Tên sản phẩm ";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(115, 91);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(123, 24);
            this.lbl_ID.TabIndex = 9;
            this.lbl_ID.Text = "ID_Sản phẩm";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(395, 13);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(97, 24);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Danh mục";
            // 
            // Danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Load += new System.EventHandler(this.Danhmuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Danhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntTaomoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGrid_Danhmuc;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_IDsanpham;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lbl_Mota;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl1;
    }
}
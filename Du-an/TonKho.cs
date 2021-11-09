using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //them thu vien

namespace Du_an
{
    public partial class TonKho : Form
    {
        KetNoi kn = new KetNoi(); //khoi tao class
        public TonKho()
        {
            InitializeComponent();
        }

        private void Bang_TonKho()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from TonKho ORDER BY Ngay");
            DataGrid_TonKho.DataSource = dta;
        }

        private void Bang_SanPham()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from SanPham ORDER BY Id_SanPham");
            cboId_SanPham.DataSource = dta;
            cboId_SanPham.DisplayMember = "Ten";
            cboId_SanPham.ValueMember = "Id_SanPham";
        }

        private void HienThi_DuLieu()
        {
            txtNgay.DataBindings.Clear();
            txtNgay.DataBindings.Add("text", DataGrid_TonKho.DataSource, "Ngay");

            cboId_SanPham.DataBindings.Clear();
            cboId_SanPham.DataBindings.Add("text", DataGrid_TonKho.DataSource, "Id_SanPham");

            txtSldau.DataBindings.Clear();
            txtSldau.DataBindings.Add("text", DataGrid_TonKho.DataSource, "Sldau");

            txtSlnhap.DataBindings.Clear();
            txtSlnhap.DataBindings.Add("text", DataGrid_TonKho.DataSource, "Slnhap");

            txtSlxuat.DataBindings.Clear();
            txtSlxuat.DataBindings.Add("text", DataGrid_TonKho.DataSource, "Slxuat");

            txtSlCuoi.DataBindings.Clear();
            txtSlCuoi.DataBindings.Add("text", DataGrid_TonKho.DataSource, "SlCuoi");
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            Bang_TonKho();
            Bang_SanPham();
            btnLuu.Enabled = false;
            HienThi_DuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtNgay.Text = System.DateTime.Now.ToString("dd MMMM yyyy");
            cboId_SanPham.Text = null;
            txtSldau.Value = 0;
            txtSlnhap.Value = 0;
            txtSlxuat.Value = 0;
            txtSlCuoi.Text = ".............";
            txtNgay.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select Ngay from TonKho where Ngay= '" + txtNgay.Text + "'";
            SqlCommand smd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_d1 = smd.ExecuteReader();

            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Ngày bị trùng, vui lòng nhập lại", "Thông báo");
                txtNgay.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                DialogResult tb;
                tb = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    string sql_luu = "Insert into TonKho values ('" + txtNgay.Text + "', '" + cboId_SanPham.SelectedValue + "', " + txtSldau.Value + ", " + txtSlnhap.Value + ", " + txtSlxuat.Value + ")";
                    kn.ThucThi(sql_luu);
                }
                Bang_TonKho();
                HienThi_DuLieu();
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_sua = "update TonKho set Id_SanPham = '" + cboId_SanPham.SelectedValue + "', Sldau = " + txtSldau.Value + ", Slnhap = " + txtSlnhap.Value + ", Slxuat = " + txtSlxuat.Value + " where Ngay ='" + txtNgay.Text + "'";
                kn.ThucThi(sql_sua);
            }
            Bang_TonKho();
            HienThi_DuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_xoa = "Delete TonKho where Ngay = '" + txtNgay.Text + "'";
                kn.ThucThi(sql_xoa);
            }
            Bang_TonKho();
            HienThi_DuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK) this.Close();
        }
    }
}

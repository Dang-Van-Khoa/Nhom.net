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
    public partial class SanPham : Form
    {
        KetNoi kn = new KetNoi(); //khoi tao class
        public SanPham()
        {
            InitializeComponent();
        }

        private void Bang_SanPham()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from SanPham ORDER BY Id_SanPham");
            DataGrid_SanPham.DataSource = dta;
        }

        private void Bang_Nhacc()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from Nhacc ORDER BY Manhacc");
            cboManhacc.DataSource = dta;
            cboManhacc.DisplayMember = "Manhacc";
            cboManhacc.ValueMember = "Manhacc";
        }

        private void HienThi_DuLieu()
        {
            txtId_SanPham.DataBindings.Clear();
            txtId_SanPham.DataBindings.Add("text", DataGrid_SanPham.DataSource, "Id_SanPham");

            cboManhacc.DataBindings.Clear();
            cboManhacc.DataBindings.Add("text", DataGrid_SanPham.DataSource, "Manhacc");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", DataGrid_SanPham.DataSource, "Ten");

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("text", DataGrid_SanPham.DataSource, "NoiDung");

            txtGiamGia.DataBindings.Clear();
            txtGiamGia.DataBindings.Add("text", DataGrid_SanPham.DataSource, "GiamGia");

            txtAnh.DataBindings.Clear();
            txtAnh.DataBindings.Add("text", DataGrid_SanPham.DataSource, "Anh");

            txtNgayTao.DataBindings.Clear();
            txtNgayTao.DataBindings.Add("text", DataGrid_SanPham.DataSource, "NgayTao");

            txtLuotXem.DataBindings.Clear();
            txtLuotXem.DataBindings.Add("text", DataGrid_SanPham.DataSource, "LuotXem");
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Bang_SanPham();
            Bang_Nhacc();
            btnLuu.Enabled = false;
            HienThi_DuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtId_SanPham.Text = "";
            cboManhacc.Text = null;
            txtTen.Text = "";
            txtGia.Value = 0;
            txtNoiDung.Text = "";
            txtGiamGia.Value = 0;
            txtAnh.Image = null;
            txtNgayTao.Text = System.DateTime.Now.ToString("dd MMMM yyyy");
            txtLuotXem.Value = 0;
            txtId_SanPham.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select Id_SanPham from SanPham where Id_SanPham= '" + txtId_SanPham.Text + "'";
            SqlCommand smd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_d1 = smd.ExecuteReader();

            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã sản phẩm bị trùng, vui lòng nhập lại", "Thông báo");
                txtId_SanPham.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                DialogResult tb;
                tb = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    string sql_luu = "Insert into SanPham values ('" + txtId_SanPham.Text + "', '" + cboManhacc.SelectedValue + "', '" + txtTen.Text + "', " + txtGia.Value + ", '" + txtNoiDung.Text + "', " + txtGiamGia.Value + ", '" + txtAnh.Text + "', '" + txtNgayTao.Text + "', " + txtLuotXem.Value + ")";
                    kn.ThucThi(sql_luu);
                }
                Bang_SanPham();
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
                string sql_sua = "update SanPham set Manhacc = '" + cboManhacc.SelectedValue + "', Ten = '" + txtTen.Text + "', Gia = " + txtGia.Value + ", NoiDung = '" + txtNoiDung.Text + "', GiamGia = " + txtGiamGia.Value + ", Anh = '" + txtAnh.Text + "', NgayTao = '" + txtNgayTao.Text + "', LuotXem = " + txtLuotXem.Value + " where Id_SanPham ='" + txtId_SanPham.Text + "'";
                kn.ThucThi(sql_sua);
            }
            Bang_SanPham();
            HienThi_DuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_xoa = "Delete SanPham where Id_SanPham = '" + txtId_SanPham.Text + "'";
                kn.ThucThi(sql_xoa);
            }
            Bang_SanPham();
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

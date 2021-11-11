using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Du_an
{
    public partial class GiaoDich : Form
    {
        KetNoi kn = new KetNoi();
        public GiaoDich()
        {
            InitializeComponent();
        }
        private void Bang_GiaoDich()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from GiaoDich ORDER BY Id_GiaoDich");
            dataGrid_GiaoDich.DataSource = dta;
        }
        private void Bang_NguoiDung()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from NguoiDung ORDER BY Id_NguoiDung");
            cboIdNguoiDung.DataSource = dta;
            cboIdNguoiDung.DisplayMember = "Id_NguoiDung";
            cboIdNguoiDung.ValueMember = "Id_NguoiDung";
        }


        private void HienThi_DuLieu()
        {
            txtId_GiaoDich.DataBindings.Clear();
            txtId_GiaoDich.DataBindings.Add("text", dataGrid_GiaoDich.DataSource, "Id_GiaoDich");

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("text", dataGrid_GiaoDich.DataSource, "TrangThai");

            cboIdNguoiDung.DataBindings.Clear();
            cboIdNguoiDung.DataBindings.Add("text", dataGrid_GiaoDich.DataSource, "Id_NguoiDung");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dataGrid_GiaoDich.DataSource, "Ten");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGrid_GiaoDich.DataSource, "Email");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dataGrid_GiaoDich.DataSource, "DienThoai");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataGrid_GiaoDich.DataSource, "TongTien");

            txtHinhThucTra.DataBindings.Clear();
            txtHinhThucTra.DataBindings.Add("Text", dataGrid_GiaoDich.DataSource, "HinhThucTra");

            txtNgayTao.DataBindings.Clear();
            txtNgayTao.DataBindings.Add("Text", dataGrid_GiaoDich.DataSource, "NgayTao");
        }

        private void GiaoDich_Load(object sender, EventArgs e)
        {
            Bang_GiaoDich();
            Bang_NguoiDung();
            btnLuu.Enabled = false;
            HienThi_DuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtId_GiaoDich.Text = "";
            txtTrangThai.Text = "";
            cboIdNguoiDung.Text = null;
            txtTen.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
            txtTongTien.Text = "";
            txtHinhThucTra.Text = "";
            txtNgayTao.Text = System.DateTime.Now.ToString("dd MMMM yyyy");
            txtId_GiaoDich.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select Id_GiaoDich from GiaoDich where Id_GiaoDich= '" + txtId_GiaoDich.Text + "'";
            SqlCommand smd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_d1 = smd.ExecuteReader();

            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã Giao Dịch bị trùng, vui lòng nhập lại", "Thông báo");
                txtId_GiaoDich.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                DialogResult tb;
                tb = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    string sql_luu = "Insert into GiaoDich values ('" + txtId_GiaoDich.Text + "', '" + txtTrangThai.Text + "', '" + cboIdNguoiDung.SelectedValue + "', '" + txtTen.Text + "', '" + txtEmail.Text + "', '" + txtDienThoai.Text + "','" + txtTongTien.Text + "', '" + txtHinhThucTra.Text + "', '" + txtNgayTao.Text + "')";
                    kn.ThucThi(sql_luu);
                }
                Bang_GiaoDich();
                HienThi_DuLieu();
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void cboIdNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from NguoiDung where Id_NguoiDung= '" + cboIdNguoiDung.SelectedValue + "'");
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                foreach(DataRow row in dta.Rows)
                {
                    txtTen.Text = row["Ten"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtDienThoai.Text = row["DienThoai"].ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_sua = "update GiaoDich set TrangThai=" + txtTrangThai.Value + ",Id_NguoiDung='" + cboIdNguoiDung.SelectedValue + "',Ten='" + txtTen.Text + "',Email='" + txtEmail.Text + "' ,DienThoai ='" + txtDienThoai.Text + "',TongTien ='" + txtTongTien.Text + "', HinhThucTra='" + txtHinhThucTra.Text + "',NgayTao='" + txtNgayTao.Text + "' where Id_GiaoDich ='" + txtId_GiaoDich.Text + "'"; ;
                kn.ThucThi(sql_sua);
            }
            Bang_GiaoDich();
            HienThi_DuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_delete = "Delete GiaoDich where Id_GiaoDich ='" + txtId_GiaoDich.Text + "'";
                kn.ThucThi(sql_delete);
            }
            Bang_GiaoDich();
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

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
    public partial class NguoiDung : Form
    {
        KetNoi kn = new KetNoi();
        public NguoiDung()
        {
            InitializeComponent();
        }

        private void Bang_NguoiDung()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from NguoiDung ORDER BY Id_NguoiDung");
            dataGrid_NguoiDung.DataSource = dta;
        }

        private void HienThi_DuLieu()
        {
            txtId_NguoiDung.DataBindings.Clear();
            txtId_NguoiDung.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "id_NguoiDung");

            txtVaiTro.DataBindings.Clear();
            txtVaiTro.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "VaiTro");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "Ten");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "Email");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "DienThoai");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "DiaChi");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "MatKhau");

            txtNgayTao.DataBindings.Clear();
            txtNgayTao.DataBindings.Add("Text", dataGrid_NguoiDung.DataSource, "NgayTao");


        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            Bang_NguoiDung();
            btnLuu.Enabled = false;
            HienThi_DuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
          
            txtId_NguoiDung.Text = "";
            txtVaiTro.Value = 0;
            txtTen.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtNgayTao.Text = System.DateTime.Now.ToString("dd MMMM yyyy");
            txtId_NguoiDung.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select Id_NguoiDung from NguoiDung where Id_NguoiDung= '" + txtId_NguoiDung.Text + "'";
            SqlCommand smd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_d1 = smd.ExecuteReader();

            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã người dùng bị trùng, vui lòng nhập lại", "Thông báo");
                txtId_NguoiDung.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                DialogResult tb;
                tb = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    string sql_luu = "Insert into NguoiDung values ('" + txtId_NguoiDung.Text + "', " + txtVaiTro.Value + ", '" + txtTen.Text + "', '" + txtEmail.Text + "', '" + txtDienThoai.Text + "','" + txtDiaChi.Text + "', '" + txtMatKhau.Text + "', '" + txtNgayTao.Text+  "')";
                    kn.ThucThi(sql_luu);
                }
                Bang_NguoiDung();
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
                string sql_sua = "update NguoiDung set VaiTro="+txtVaiTro.Value+",Ten='"+txtTen.Text+"',Email='"+txtEmail.Text + "' ,DienThoai ='"+txtDienThoai.Text+"',DiaChi ='"+txtDiaChi.Text +"', MatKhau='" + txtMatKhau.Text + "',NgayTao='" + txtNgayTao.Text + "' where Id_NguoiDung ='" + txtId_NguoiDung.Text + "'"; ;
                kn.ThucThi(sql_sua);
            }
            Bang_NguoiDung();
            HienThi_DuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_delete = "Delete NguoiDung where Id_NguoiDung ='" + txtId_NguoiDung.Text + "'";
                kn.ThucThi(sql_delete);
            }
            Bang_NguoiDung();
            HienThi_DuLieu();
           
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK) this.Close();
        }

        private void lblNgayTao_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayTao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_NguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

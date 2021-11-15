using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace Du_an
{
    public partial class Dangnhap : Form
    {
        KetNoi kn = new KetNoi();
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void Bang_Dangnhap()  
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from DANGNHAP ");
            dataGrid_Dangnhap.DataSource = dta;
        }
        private void HienThi_DuLieu()
        {
            txt_Taikhoan.DataBindings.Clear();
            txt_Taikhoan.DataBindings.Add("Text", dataGrid_Dangnhap.DataSource, "TaiKhoa");

            txt_Matkhau.DataBindings.Clear();
            txt_Matkhau.DataBindings.Add("Text", dataGrid_Dangnhap.DataSource, "MatKhau");

        }
        private void Dangnhap_Load(object sender, EventArgs e)
        {
            Bang_Dangnhap();
            HienThi_DuLieu();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        { 
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn đăng nhập không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK) this.Close();
            Bang_Dangnhap();
            HienThi_DuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK) this.Close();
        }

        private void dataGrid_Dangnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

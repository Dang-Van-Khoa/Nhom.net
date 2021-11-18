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
    public partial class DangNhap : Form
    {
        KetNoi kn = new KetNoi(); //khoi tao class
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Bang_Dangnhap()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from DANGNHAP ");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu(); //ket noi du lieu

            string DN = txtTaiKhoan.Text;
            string MK = txtMatKhau.Text;

            string sql_login = "Select TaiKhoa, MatKhau From DANGNHAP where TaiKhoa = '" + DN + "' and MatKhau = '" + MK + "'";

            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);

            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                //Hien thi mot form main
                Form frmmain = new Form1();
                frmmain.Show();
                //Visible = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

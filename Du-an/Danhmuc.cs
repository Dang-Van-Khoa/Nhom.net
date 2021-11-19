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
    public partial class Danhmuc : Form
    {
        KetNoi kn = new KetNoi();
        public Danhmuc()
        {
            InitializeComponent();
        }

        private void Bang_Danhmuc()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from Danhmuc ORDER BY Id_Sanpham");
            dataGrid_Danhmuc.DataSource = dta;
        }
        private void HienThi_DuLieu()
        {
            txt_IDsanpham.DataBindings.Clear();
            txt_IDsanpham.DataBindings.Add("Text", dataGrid_Danhmuc.DataSource, "id_sanpham");

            txt_Ten.DataBindings.Clear();
            txt_Ten.DataBindings.Add("Text", dataGrid_Danhmuc.DataSource, "Ten");

            txt_MoTa.DataBindings.Clear();
            txt_MoTa.DataBindings.Add("Text", dataGrid_Danhmuc.DataSource, "Mota");

        }

        private void Danhmuc_Load(object sender, EventArgs e)
        {
            Bang_Danhmuc();
            btnLuu.Enabled = false;
            HienThi_DuLieu();
        }

        private void bntTaomoi_Click(object sender, EventArgs e)
        {
            txt_IDsanpham.Text = "";
            txt_Ten.Text = "";
            txt_MoTa.Text = "";
            txt_IDsanpham.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select Id_Sanpham from Sanpham where Id_Sanpham= '" + txt_IDsanpham.Text + "'";
            SqlCommand smd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_d1 = smd.ExecuteReader();

            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã sản phẩm bị trùng, vui lòng nhập lại", "Thông báo");
                txt_IDsanpham.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                DialogResult tb;
                tb = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    string sql_luu = "Insert into Sanpham values ('" + txt_IDsanpham.Text + "', '" + txt_Ten.Text + "', '" + txt_MoTa.Text + "')";
                    kn.ThucThi(sql_luu);
                }
                Bang_Danhmuc();
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
                string sql_sua = "update Sanpham set Ten='" + txt_Ten.Text + "',MoTa='" + txt_MoTa.Text + "' where Id_sanpham='" + txt_IDsanpham.Text + "'"; ;
                kn.ThucThi(sql_sua);
            }
            Bang_Danhmuc();
            HienThi_DuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                string sql_delete = "Delete Sanpham where Id_sanpham ='" + txt_IDsanpham.Text + "'";
                kn.ThucThi(sql_delete);
            }
            Bang_Danhmuc();
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

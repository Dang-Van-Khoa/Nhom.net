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
using System.IO; //them thu vien

namespace Du_an
{
    public partial class SanPham : Form
    {
        KetNoi kn = new KetNoi(); //khoi tao class
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-5594BKK\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
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
            dta = kn.Lay_DulieuBang("select * from Nhacc ORDER BY MaNhacc");
            cboManhacc.DataSource = dta;
            cboManhacc.DisplayMember = "TenNhacc"; //Trường hiển thị
            cboManhacc.ValueMember = "MaNhacc"; //Trường giá trị
        }

        private void HienThi_DuLieu()
        {
            txtId_SanPham.DataBindings.Clear();
            txtId_SanPham.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "Id_SanPham");

            cboManhacc.DataBindings.Clear();
            cboManhacc.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "Manhacc");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "Ten");

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "Gia");

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "NoiDung");

            txtGiamGia.DataBindings.Clear();
            txtGiamGia.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "GiamGia");

            picAnh.DataBindings.Clear();
            picAnh.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "Anh");

            txtNgayTao.DataBindings.Clear();
            txtNgayTao.DataBindings.Add("Value", DataGrid_SanPham.DataSource, "NgayTao");

            txtLuotXem.DataBindings.Clear();
            txtLuotXem.DataBindings.Add("Text", DataGrid_SanPham.DataSource, "LuotXem");
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Bang_SanPham();
            Bang_Nhacc();
            btnLuu.Enabled = false;
            HienThi_DuLieu();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D://NEU";
            openFileDialog1.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            openFileDialog1.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = openFileDialog1.FileName;
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                //txtAnh.Text = openFileDialog1.FileName;
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtId_SanPham.Text = "";
            cboManhacc.Text = null;
            txtTen.Text = "";
            txtGia.Text = "0";
            txtNoiDung.Text = "";
            txtGiamGia.Text = "0";
            picAnh.Image = null;
            txtNgayTao.Text = System.DateTime.Now.ToString("dd MMMM yyyy");
            txtLuotXem.Text = "0";
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
                    byte[] b = ImageToByteArray(picAnh.Image);
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into SanPham values(@Id_SanPham, @MaNhacc, @Ten, @Gia, @NoiDung, @GiamGia, @Anh, @NgayTao, @LuotXem)", cnn);
                    cmd.Parameters.Add("@Id_SanPham", txtId_SanPham.Text);
                    cmd.Parameters.Add("@MaNhacc", cboManhacc.SelectedValue);
                    cmd.Parameters.Add("@Ten", txtTen.Text);
                    cmd.Parameters.Add("@Gia", txtGia.Text);
                    cmd.Parameters.Add("@NoiDung", txtNoiDung.Text);
                    cmd.Parameters.Add("@GiamGia", txtGiamGia.Text);
                    cmd.Parameters.Add("@Anh", b);
                    cmd.Parameters.Add("@NgayTao", txtNgayTao.Text);
                    cmd.Parameters.Add("@LuotXem", txtLuotXem.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
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
                byte[] b = ImageToByteArray(picAnh.Image);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("update SanPham set Manhacc = @MaNhacc, Ten = @Ten, Gia = @Gia, NoiDung = @NoiDung, GiamGia = @GiamGia, Anh = @Anh, NgayTao = @NgayTao, LuotXem = @LuotXem where Id_SanPham = @Id_SanPham", cnn);
                cmd.Parameters.Add("@Id_SanPham", txtId_SanPham.Text);
                cmd.Parameters.Add("@MaNhacc", cboManhacc.SelectedValue);
                cmd.Parameters.Add("@Ten", txtTen.Text);
                cmd.Parameters.Add("@Gia", txtGia.Text);
                cmd.Parameters.Add("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.Add("@GiamGia", txtGiamGia.Text);
                cmd.Parameters.Add("@Anh", b);
                cmd.Parameters.Add("@NgayTao", txtNgayTao.Text);
                cmd.Parameters.Add("@LuotXem", txtLuotXem.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
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

        //Chuyển từ Image sang byte[]
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();

        }

        //Chuyển từ byte[] sang Image
        Image ByteArrayToImage (byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void DataGrid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = DataGrid_SanPham.CurrentCell.RowIndex;
            txtId_SanPham.Text = DataGrid_SanPham.Rows[r].Cells[0].Value.ToString();
            cboManhacc.Text = DataGrid_SanPham.Rows[r].Cells[1].Value.ToString();
            txtTen.Text = DataGrid_SanPham.Rows[r].Cells[2].Value.ToString();
            txtGia.Text = DataGrid_SanPham.Rows[r].Cells[3].Value.ToString();
            txtNoiDung.Text = DataGrid_SanPham.Rows[r].Cells[4].Value.ToString();
            txtGiamGia.Text = DataGrid_SanPham.Rows[r].Cells[5].Value.ToString();
            byte[] b = (byte[]) DataGrid_SanPham.Rows[r].Cells[6].Value;
            picAnh.Image = ByteArrayToImage(b);
            txtNgayTao.Text = DataGrid_SanPham.Rows[r].Cells[7].Value.ToString();
            txtLuotXem.Text = DataGrid_SanPham.Rows[r].Cells[8].Value.ToString();
        }
    }
}

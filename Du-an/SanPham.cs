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
using System.IO; //thêm thư viện
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtId_SanPham.Text = "";
            cboManhacc.Text = null;
            txtTen.Text = "";
            txtGia.Text = "0";
            txtNoiDung.Text = "";
            txtGiamGia.Text = "0";
            //byte[] b = ImageToByteArray(picAnh.Image);
            txtAnh.Text = "";
            picAnh.Image = null;
            //picAnh.Image = ByteArrayToImage(b);
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
                    //byte[] picAnhString = ImageToByteArray(picAnh.Image);
                    string sql_luu = "Insert into SanPham values ('" + txtId_SanPham.Text + "', '" + cboManhacc.SelectedValue + "', '" + txtTen.Text + "', '" + txtGia.Text + "', '" + txtNoiDung.Text + "', '" + txtGiamGia.Text + "', '" + picAnh.Text + "', '" + txtNgayTao.Text + "', '" + txtLuotXem.Text + "')";
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
                //byte[] picAnhString = ImageToByteArray(picAnh.Image);
                string sql_sua = "update SanPham set Manhacc = '" + cboManhacc.SelectedValue + "', Ten = '" + txtTen.Text + "', Gia = '" + txtGia.Text + "', NoiDung = '" + txtNoiDung.Text + "', GiamGia = '" + txtGiamGia.Text + "', Anh = '" + picAnh.Text + "' , NgayTao = '" + txtNgayTao.Text + "', LuotXem = '" + txtLuotXem.Text + "' where Id_SanPham ='" + txtId_SanPham.Text + "'";
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

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            dlgOpen.RestoreDirectory = true;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                //byte[] picAnhString = ImageToByteArray(picAnh.Image);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        //Chuyển Image sang byte[]
        //byte[] ImageToByteArray (Image img)
        //{
            //MemoryStream m = new MemoryStream();
            //img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            //return m.ToArray();
            //m.Close();
        //}

        //Chuyen file Anh sang Byte
        //byte[] PathToByteArray (string path)
        //{
            //MemoryStream m = new MemoryStream();
            //Image img = Image.FromFile(path);
            //img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            //return m.ToArray();
        //}

        //Chuyển từ byte[] sang Image
        //Image ByteArrayToImage (byte[] b)
        //{
            //MemoryStream m = new MemoryStream();
            //return Image.FromStream(m);
        //}

        private void DataGrid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int r = DataGrid_SanPham.CurrentCell.RowIndex;
            //byte[] b = (byte[]) DataGrid_SanPham.Rows[r].Cells[7].Value;
            //picAnh.Image = ByteArrayToImage(b);
        }
    }
}

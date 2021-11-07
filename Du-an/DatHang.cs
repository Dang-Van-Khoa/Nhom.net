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
    public partial class DatHang : Form
    {
        public DatHang()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void BangDatHang()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM DatHang");
            dataGridView1.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void BangGiaoDich()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM GiaoDich");
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "Id_GiaoDich";
            comboBox1.ValueMember = "Id_GiaoDich";
        }

        public void BangNguoiDung()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM NguoiDung");
            comboBox2.DataSource = dta;
            comboBox2.DisplayMember = "Id_NguoiDung";
            comboBox2.ValueMember = "Id_NguoiDung";
        }

        public void BangSanPham()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM SanPham");
            comboBox3.DataSource = dta;
            comboBox3.DisplayMember = "Id_SanPham";
            comboBox3.ValueMember = "Id_SanPham";
        }

        private void Hienthi_Dulieu()
        {
            comboBox1.DataBindings.Clear();
            comboBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Id_GiaoDich");

            comboBox2.DataBindings.Clear();
            comboBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Id_NguoiDung");

            comboBox3.DataBindings.Clear();
            comboBox3.DataBindings.Add("Text", dataGridView1.DataSource, "Id_SanPham");

            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "SoLuongMua");

            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Gia");

            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "TrangThai");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql_save = "Insert into DatHang Values('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "',";
            sql_save = sql_save + "'" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            kn.ThucThi(sql_save);
            BangDatHang();
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            BangDatHang();
            BangGiaoDich();
            BangNguoiDung();
            BangSanPham();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql_delete = "Delete DatHang where Id_GiaoDich ='" + textBox1.Text + "'";
            kn.ThucThi(sql_delete);
            BangDatHang();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

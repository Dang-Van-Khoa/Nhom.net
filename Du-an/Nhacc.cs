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
    public partial class Nhacc : Form
    {
        public Nhacc()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void BangNhacc()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM Nhacc");
            dataGridView1.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "MaNhacc");

            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "TenNhacc");

            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");

            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "DienThoai");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
            button2.Enabled = true;
        }

        private void Nhacc_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            BangNhacc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strKra = "Select MaNhacc from Nhacc where MaNhacc = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();

            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã nhà cung cấp này đã tồn tại, nhập lại mã khác", "thông báo");
                textBox1.Focus();
                doc_dl.Close();
                doc_dl.Dispose();

            }
            else
            {
                string sql_save = "Insert into Nhacc Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                kn.ThucThi(sql_save);
                BangNhacc();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql_update = "Update Nhacc Set TenNhacc = '" + textBox2.Text + "', DiaChi = '" + textBox3.Text + "', DienThoai = '" + textBox4.Text + "' where MaNhacc = '" + textBox1.Text + "'";
            kn.ThucThi(sql_update);
            BangNhacc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql_delete = "Delete Nhacc where MaNhacc ='" + textBox1.Text + "'";
            kn.ThucThi(sql_delete);
            BangNhacc();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

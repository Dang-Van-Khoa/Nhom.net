using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_an
{
    public partial class TimKiemSP : Form
    {
        public TimKiemSP()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void TimKiemSP_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select * from SanPham");
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "Ten";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string Sql_tk = string.Format("Execute ThongTinSP '{1}'", comboBox1.Text);
            dta = kn.Lay_DulieuBang(Sql_tk);
            Grid_KETQUA.DataSource = dta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

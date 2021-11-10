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
    public partial class Bc_SPham : Form
    {
        public Bc_SPham()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void Bc_SPham_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from SanPham");
            Bc_SanPham BC = new Bc_SanPham();
            BC.SetDataSource(dta);
            CRVSanPham.ReportSource = BC;
        }
    }
}

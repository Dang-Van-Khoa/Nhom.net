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
    public partial class Bc_KhoHang : Form
    {
        public Bc_KhoHang()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void Bc_KhoHang_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from TonKho");
            Bc_TonKho BC = new Bc_TonKho();
            BC.SetDataSource(dta);
            CRVTonKho.ReportSource = BC;
        }
    }
}

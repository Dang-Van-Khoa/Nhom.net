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
    public partial class Bc_NCC : Form
    {
        public Bc_NCC()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Bc_NCC_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from Nhacc");
            Bc_Nhacc BC = new Bc_Nhacc();
            BC.SetDataSource(dta);
            CRV.ReportSource = BC;
        }
    }
}

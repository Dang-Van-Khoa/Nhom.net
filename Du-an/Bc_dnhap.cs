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
    public partial class Bc_dnhap : Form
    {
        KetNoi kn = new KetNoi();
        public Bc_dnhap()
        {
            InitializeComponent();
        }

        private void Bc_dnhap_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DANGNHAP");
            Bc_DANGNHAP BC = new Bc_DANGNHAP();
            BC.SetDataSource(dta);
           CRV_Dnhap.ReportSource = BC;
        }
    }
}

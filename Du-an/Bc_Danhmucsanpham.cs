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
    public partial class Bc_Danhmucsanpham : Form
    {
        KetNoi kn = new KetNoi();
        public Bc_Danhmucsanpham()
        {
            InitializeComponent();
        }

        private void Bc_Danhmucsanpham_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DANHMUC");
            Bc_Danhmuc BC = new Bc_Danhmuc();
            BC.SetDataSource(dta);
            CRV_Dmuc.ReportSource = BC;
        }
    }
}

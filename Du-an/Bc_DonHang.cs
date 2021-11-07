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
    public partial class Bc_DonHang : Form
    {
        public Bc_DonHang()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void Bc_DonHang_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DatHang");
            Bc_DonDat BC = new Bc_DonDat();
            BC.SetDataSource(dta);
            CRV.ReportSource = BC;
        }
    }
}

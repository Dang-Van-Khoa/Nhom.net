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
    public partial class Bc_GiaoDich : Form
    {
        public Bc_GiaoDich()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void Bc_GiaoDich_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from GiaoDich");
            Bc_GDich BC = new Bc_GDich();
            BC.SetDataSource(dta);
            CRVGiaoDich.ReportSource = BC;
        }
    }
}

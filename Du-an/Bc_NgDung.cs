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
    public partial class Bc_NgDung : Form
    {
        KetNoi kn = new KetNoi();
        public Bc_NgDung()
        {
            InitializeComponent();
        }

        private void Bc_NgDung_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from NguoiDung");
            Bc_NguoiDung BC = new Bc_NguoiDung();
            BC.SetDataSource(dta);
           // CRV.ReportSource = BC;
        }
    }
}

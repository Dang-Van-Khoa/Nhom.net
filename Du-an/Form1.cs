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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NCC = new Nhacc();
            NCC.Show();
        }

        private void DatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DH = new DatHang();
            DH.Show();
        }

        private void donDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DonDat = new Bc_DonHang();
            DonDat.Show();
        }

        private void bcNhaccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Nhacc = new Bc_NCC();
            Nhacc.Show();
        }

        private void danhSachHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SanPham = new SanPham();
            SanPham.Show();
        }

        private void khoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TonKho = new TonKho();
            TonKho.Show();
        }

        private void timKiemSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TKSP = new TimKiemSP();
            TKSP.Show();
        }
    }
}

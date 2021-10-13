using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._2
{
    public partial class frmLatihanTiga3 : Form
    {
        public frmLatihanTiga3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            var nama = txtnama.Text;
            var pendidikan = cmbpendidikan.Text;
            var pekerjaan = lstpekerjaan.Text;

            txtpesan1.Text = string.Format("Halo {0}", nama);
            txtpesan2.Text = string.Format("Pendidikan anda {0} ya?", pendidikan);
            txtpesan3.Text = string.Format("Anda seorang {0}, hebat !!!", pekerjaan);

        }
    }
}

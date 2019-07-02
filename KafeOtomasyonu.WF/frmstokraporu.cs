using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu.WF
{
    public partial class frmstokraporu : Form
    {
        public frmstokraporu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPersonelRaporu_Click(object sender, EventArgs e)
        {

            frmpersonelperformansraporu fpt = new frmpersonelperformansraporu();
            fpt.Show();
            this.Hide();
        }

        private void btnStokDurumRaporu_Click(object sender, EventArgs e)
        {

            frmstokraporu fpt = new frmstokraporu();
            fpt.Show();
            this.Hide();
        }

        private void btnUrunSatisRaporu_Click(object sender, EventArgs e)
        {

            frmurunsatısraporu fpt = new frmurunsatısraporu();
            fpt.Show();
            this.Hide();
        }

        private void frmstokraporu_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmrapor : Form
    {
        public frmrapor()
        {
            InitializeComponent();
        }

        private void günlükKasaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmurunsatısraporu fpt = new frmurunsatısraporu();
            fpt.Show();
            this.Hide();
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

        private void frmrapor_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmuruntanimlama fpt = new frmuruntanimlama();
            fpt.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmasasatis fpt = new frmmasasatis();
            fpt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmpersoneltanimlama fpt = new frmpersoneltanimlama();
            fpt.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmrapor fpt = new frmrapor();
            fpt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmmenu fpt = new frmmenu();
            fpt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmstoktakip fpt = new frmstoktakip();
            fpt.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmkategori fpt = new frmkategori();
            fpt.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmmasaEkle fpt = new frmmasaEkle();
            fpt.Show();
            this.Hide();
        }
    }
}

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
    public partial class frmsiparis : Form
    {
        public Adisyon a;
        public frmsiparis()
        {
            InitializeComponent();
            ustKategori();


        }
        public void ustKategori()
        {
            var kategoriler = db.Kategori.Where(x => x.ustKategoriID == null).ToArray();
            foreach (Kategori item in kategoriler)
            {
                Button b = new Button();
                b.Size = new Size(69, 37);
                b.Text = item.icerik;
                b.Name = item.icerik;
                b.Tag = item.kategoriID;
                b.Click += new EventHandler(buttonUstClick);
                flowLayoutPanel1.Controls.Add(b);
            }
        }
        cafeVTContext db = new cafeVTContext();
            
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void buttonUstClick(object sender, EventArgs e)
        {
            Button i =  (Button)sender;
         //  MessageBox.Show(i.Text);
            var altKategorileri = db.Kategori.Where(x => x.ustKategoriID == (int)i.Tag).ToArray();
            if (altKategorileri != null)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Kategori item in altKategorileri)
                {
                    Button b = new Button();
                    b.Size = new Size(69, 37);
                    b.Text = item.icerik;
                    b.Name = item.icerik;
                    b.Tag = item.kategoriID;
                    b.Click += new EventHandler(buttonAltClick);
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
        }
        private void buttonAltClick(object sender, EventArgs e)
        {
            Button i = (Button)sender;
            var urunler = db.Urun.Where(x => x.kategoriID == (int)i.Tag).ToArray();
            if (urunler != null)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Urun item in urunler)
                {
                    Button b = new Button();
                    b.Size = new Size(69, 37);
                    b.Text = item.adi;
                    b.Name = item.adi;
                    b.Tag = item.urunID;
                    b.Click += new EventHandler(urunClick);
                    flowLayoutPanel1.Controls.Add(b);

                }
            }


        }
        private void urunClick(object sender, EventArgs e)
        {
            Button i = (Button)sender;

        }
        private void frmsiparis_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {

            frmayarlar fpt = new frmayarlar();
            fpt.Show();
            this.Hide();
        }

        private void btnmasasatıs_Click(object sender, EventArgs e)
        {

            frmmasasatis fpt = new frmmasasatis();
            fpt.Show();
            this.Hide();
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {

            frmodeme fpt = new frmodeme();
            fpt.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ustKategori();
        }
    }
}

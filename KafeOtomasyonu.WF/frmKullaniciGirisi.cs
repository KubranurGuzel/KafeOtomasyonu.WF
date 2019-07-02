using KafeOtomasyonu;
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
    public partial class frmKullaniciGirisi : Form
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }

        cafeVTContext db = new cafeVTContext();
        private void frmKullaniciGirisi_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = db.Kullanici.Where(x => x.eposta == txt_eposta.Text && x.sifre == txt_sifre.Text).SingleOrDefault();

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.kullanici = kullanici;
                if (Program.kullanici.yetki == "Patron")
                {
                    frmmasasatis fpt = new frmmasasatis();
                    fpt.Show();
                    this.Hide();
                }
                else if (Program.kullanici.yetki == "Personel")
                {
                    frmmasasatis fpr = new frmmasasatis();
                    fpr.Show();
                    this.Hide();
                }
            }            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

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

    public partial class frmpersoneltanimlama : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmpersoneltanimlama()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GridGuncelle();
        }
   

        private void btnguncelle_Click(object sender, EventArgs e)
        {

         
          Kullanici k = db.Kullanici.Where(x => x.kullaniciID == kullaniciId).SingleOrDefault();
               k.eposta = txteposta.Text;
               k.sifre = txtsifre.Text;
               k.cepTel = Convert.ToDecimal(txttelno.Text);
               k.yetki = txtyetki.Text;
               k.adres = rtxtadres.Text;
                db.SaveChanges();
                GridGuncelle();
         
        }
        
        int kullaniciId;
        void verileriDoldur()
        {
            kullaniciId = Convert.ToInt32(gridpersonel.CurrentRow.Cells["kullaniciID"].Value.ToString());
            var veri = db.Kullanici.Where(x => kullaniciId == x.kullaniciID).SingleOrDefault();
            txtkuladi.Text = veri.adi;
            txtkulsoyadi.Text = veri.soyadi;
            txttcno.Text = Convert.ToString(veri.kullaniciTC);
            txteposta.Text = veri.eposta;
            txtsifre.Text = veri.sifre;
            txttelno.Text = Convert.ToString (veri.cepTel);
            txtyetki.Text = veri.yetki;
            rtxtadres.Text = veri.adres;

        }
        private void btnekle_Click(object sender, EventArgs e)
        {
              Kullanici k = new Kullanici();
            k.adi = txtkuladi.Text;
            k.soyadi = txtkulsoyadi.Text;
            k.eposta = txttelno.Text;
            k.sifre = txtsifre.Text;
            k.kullaniciTC = Convert.ToDecimal(txttcno.Text);
            k.cepTel = Convert.ToDecimal(txttelno.Text);
            k.yetki = txtyetki.Text;
            k.adres = rtxtadres.Text;

            db.Kullanici.Add(k);
            db.SaveChanges();

            MessageBox.Show(k.adi + " " + k.soyadi + " adlı kullanıcı başarı ile kaydedilmiştir.");
            txttcno.Text= "";
            txtkuladi.Text = "";
            txtkulsoyadi.Text = "";
            txttelno.Text = "";
            rtxtadres.Text = "";
            txteposta.Text = "";
            txtyetki.Text = "";
            txtsifre.Text = "";

            GridGuncelle();
        }
        public void GridGuncelle()
        {
            var kullaniciListesi = db.Kullanici.Select(x =>
              new
              {
                  x.kullaniciID,
                  x.kullaniciTC,
                  x.adi,
                  x.soyadi,
                  x.cepTel,
                  x.adres,
                  x.eposta,
                  x.sifre,
                  x.yetki
              }).ToList();
            gridpersonel.DataSource = kullaniciListesi;

            txttcno.Text = "";
            txtkuladi.Text = "";
            txtkulsoyadi.Text = "";
            txttelno.Text = "";
            rtxtadres.Text = "";
            txteposta.Text = "";
            txtyetki.Text = "";
            txtsifre.Text = "";
        }
  

        private void btnsil_Click(object sender, EventArgs e)
        {

            int id = 0;
            id = (int)gridpersonel.CurrentRow.Cells["kullaniciID"].Value;
            Kullanici k = db.Kullanici.Where(mst => id == mst.kullaniciID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(k.adi + " " + "adlı müşteri silinsin mi?", "Ürün Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.Kullanici.Remove(k);
                db.SaveChanges();
                MessageBox.Show(k.adi + " " + "adlı kullanıcı silindi. ");


                GridGuncelle();


            }

            else
            {
                MessageBox.Show("İşlem Onaylanmadı");
            }
            GridGuncelle();
        }

        private void frmpersoneltanimlama_Load(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void gridpersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();
        }
    }
}

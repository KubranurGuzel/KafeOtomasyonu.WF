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
    public partial class frmuruntanimlama : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmuruntanimlama()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
            GridGuncelle();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

           Urun u = new Urun();
           u.kategoriID  = (int)cmbkategori.SelectedValue;
           u.adi = txturunadi.Text;
           u.fiyat = Convert.ToInt32(txturunfiyati.Text);


            db.Urun.Add(u);
            db.SaveChanges();

            MessageBox.Show(u.adi +" adlı ürün  başarı ile kaydedilmiştir.");
            txturunadi.Text = "";
            txturunfiyati.Text = "";
            cmbkategori.Text = "";

            GridGuncelle();

        }
        public void GridGuncelle()
        {
            var urunListesi = db.Urun.Select(x =>
              new
              {
                  x.urunID,
                    x.kategoriID,
                    x.fiyat,
                  x.adi
                  
              }).ToList();
            gridurun.DataSource = urunListesi;

            txturunadi.Text = "";
            txturunfiyati.Text = "";
            cmbkategori.Text = "";
        }

        private void frmuruntanimlama_Load(object sender, EventArgs e)
        {
            GridGuncelle();

            var Listeurun = db.Kategori.ToList();
            cmbkategori.DataSource = Listeurun;
            cmbkategori.DisplayMember = "icerik";
            cmbkategori.ValueMember = "kategoriID";
            var Listekategori = db.Kategori.Select(x => new
            {
                x.kategoriID,
                x.icerik
            }).ToList();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)gridurun.CurrentRow.Cells["urunID"].Value;
            Urun u = db.Urun.Where(mst => id == mst.urunID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(u.adi+ "  adlı ürün silinsin mi?", "Ürün Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.Urun.Remove(u);
                db.SaveChanges();
                MessageBox.Show(u.adi + " " + "adlı ürün silindi. ");


                GridGuncelle();


            }

            else
            {
                MessageBox.Show("İşlem Onaylanmadı");
            }
            GridGuncelle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Urun u = db.Urun.Where(x => x.urunID == urunid).SingleOrDefault();
            u.kategoriID = (int)cmbkategori.SelectedValue; 
            u.adi = txturunadi.Text;
            u.fiyat = Convert.ToInt32(txturunfiyati.Text);
          
            db.SaveChanges();
            GridGuncelle();
        }
        int urunid;
        void verileriDoldur()
        {
            urunid = Convert.ToInt32(gridurun.CurrentRow.Cells["urunID"].Value.ToString());
            var veri = db.Urun.Where(x => urunid == x.urunID).SingleOrDefault();
            cmbkategori.SelectedValue= veri.kategoriID;
           txturunadi.Text = veri.adi;
            txturunfiyati.Text =Convert.ToString( veri.fiyat);


        }

        private void gridurun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();
        }
    }
}

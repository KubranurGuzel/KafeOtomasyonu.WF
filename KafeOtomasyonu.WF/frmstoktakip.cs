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
    public partial class frmstoktakip : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmstoktakip()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            

            stok s = new stok();         
            s.kategoriID = (int)cmbkategori.SelectedValue;
                    
            s.urunID = (int)cmburunadi.SelectedValue;
            
            s.birim = txtbirim.Text;
            s.miktar = Convert.ToDecimal(txturunmiktar.Text);
            s.birimFiyat = Convert.ToDecimal(txtbirimfyt.Text);
            //toplam fiyat textini otomatik doldurmak için ne yapılabibilir.
            s.toplamFiyat = Convert.ToString(s.miktar * s.birimFiyat);

            db.stok.Add(s);
            db.SaveChanges();

            MessageBox.Show(s.urunID + " adlı ürün stoğu  başarı ile kaydedilmiştir.");
            cmbkategori.Text = "";
            cmburunadi.Text = "";
            txtbirim.Text = "";
            txturunmiktar.Text = "";
            txtbirimfyt.Text = "";

            
            GridGuncelle();
        }
        public void GridGuncelle()
        {
            var stokListesi = db.stok.Select(x =>
              new
              {
                  x.stokID,
                  x.urunID,
                  x.kategoriID,
                  x.miktar,
                  x.birim,
                  x.birimFiyat,
                  x.toplamFiyat

              }).ToList();
            gridstok.DataSource = stokListesi;
            cmbkategori.Text = "";
            cmburunadi.Text = "";
            txtbirim.Text = "";
            txturunmiktar.Text = "";
            txtbirimfyt.Text = "";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void frmstoktakip_Load(object sender, EventArgs e)
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

            var Listestok = db.Urun.ToList();
            cmburunadi.DataSource = Listestok;
            cmburunadi.DisplayMember = "adi";
            cmburunadi.ValueMember = "urunID";
            var Liste = db.Urun.Select(x => new
            {
               x.urunID,
               x.adi
            
            }).ToList();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)gridstok.CurrentRow.Cells["stokID"].Value;
            stok s = db.stok.Where(mst => id == mst.stokID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(s.stokID + "  numaralı stok silinsin mi?", "Stok Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.stok.Remove(s);
                db.SaveChanges();
                MessageBox.Show(s.stokID + " " + "numralı stok silindi. ");
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
            stok s = db.stok.Where(x => x.urunID == stokid).SingleOrDefault();
            s.kategoriID =(int)cmbkategori.SelectedIndex;
            s.urunID = (int)cmburunadi.SelectedValue;
            s.birim =txtbirim.Text;
            s.miktar = Convert.ToInt32(txturunmiktar.Text);
            s.birimFiyat = Convert.ToDecimal(txtbirimfyt.Text);

            db.SaveChanges();
            GridGuncelle();
        }
        int stokid;
        void verileriDoldur()
        {
            stokid = Convert.ToInt32(gridstok.CurrentRow.Cells["stokID"].Value.ToString());
            var veri = db.stok.Where(x => stokid == x.stokID).SingleOrDefault();
            cmbkategori.SelectedValue = veri.kategoriID;
            cmburunadi.Text = Convert.ToString(veri.urunID);
            cmbkategori.Text = Convert.ToString(veri.kategoriID);
            txtbirim.Text = veri.birim;
            txturunmiktar.Text = Convert.ToString(veri.miktar);
           txtbirimfyt.Text = Convert.ToString(veri.birimFiyat);


        }

        private void gridstok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();
        }
    }
}

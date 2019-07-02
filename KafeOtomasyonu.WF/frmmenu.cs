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
    public partial class frmmenu : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmmenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            //foreach (var item in listmenu.Items)
            //{
            //    Urun u2 = (Urun)item;

            //}




            menu m = new menu();
            Urun u = new Urun();
            m.menuAdi = txtmenuadi.Text;
            m.menuIcerik = Convert.ToString(listmenu.SelectedItems);
            //u.urunID = (int)cmburunadi.SelectedValue;
            m.menuFiyati = Convert.ToDecimal(txtmfiyat.Text);


            db.menu.Add(m);
            db.Urun.Add(u);
            db.SaveChanges();

            MessageBox.Show(u.adi + " adlı ürün  başarı ile kaydedilmiştir.");
            txtmenuadi.Text = "";
            txtmfiyat.Text = "";
            //cmburunadi.Text = "";

            GridGuncelle();
        }
        public void GridGuncelle()
        {
            var menuliste= db.menu.Select(x =>
              new
              {
                  x.menuID,
                  x.menuAdi,
                  x.menuFiyati,
                  x.menuIcerik
                

              }).ToList();
            gridmenu.DataSource = menuliste;

            txtmenuadi.Text = "";
            txtmfiyat.Text = "";
            cmburunadi.Text = "";
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            GridGuncelle();
          
            var Listeurun = db.Urun.ToList();
                cmburunadi.DataSource = Listeurun;
                cmburunadi.DisplayMember = "adi";
                cmburunadi.ValueMember = "urunID";
                var ListeUrun = db.Urun.Select(x => new
                {
                    x.urunID,
                    x.adi

                }).ToList(); 

            var Listekategori = db.Kategori.ToList();
            cmbKategori.DataSource = Listekategori;
            cmbKategori.DisplayMember = "icerik";
            cmbKategori.ValueMember = "kategoriID";
            var ListeKategori = db.Kategori.Select(x => new
            {
                x.kategoriID,
                x.icerik

            }).ToList();

        
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)gridmenu.CurrentRow.Cells["menuID"].Value;
            menu m = db.menu.Where(mst => id == mst.menuID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(m.menuAdi + "  adlı menü silinsin mi?", "Ürün Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.menu.Remove(m);
                db.SaveChanges();
                MessageBox.Show(m.menuAdi + " " + "adlı menü silindi. ");


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
            menu m = db.menu.Where(x => x.menuID == menuid).SingleOrDefault();
            Urun u = db.Urun.Where(x => x.urunID == urunid).SingleOrDefault();
            u.urunID = (int)cmburunadi.SelectedValue;
            m.menuAdi = txtmenuadi.Text;
            m.menuFiyati = Convert.ToDecimal(txtmfiyat.Text);

            db.SaveChanges();
            GridGuncelle();
        }
        int urunid;
        int menuid;
        void verileriDoldur()
        {
            menuid = Convert.ToInt32(gridmenu.CurrentRow.Cells["menuID"].Value.ToString());
            var veri = db.menu.Where(x => menuid == x.menuID).SingleOrDefault();

            urunid = Convert.ToInt32(gridmenu.CurrentRow.Cells["urunID"].Value.ToString());
            var veriu = db.Urun.Where(x => urunid == x.urunID).SingleOrDefault();
            cmburunadi.SelectedValue = veri.menuID;
            txtmenuadi.Text = veri.menuAdi;
            txtmfiyat.Text = Convert.ToString(veri.menuFiyati);
        }

        private void listmenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listmenu.Items.Add(cmburunadi.Text);

        }        
        private void cmburunadi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

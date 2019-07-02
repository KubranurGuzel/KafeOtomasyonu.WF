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
    public partial class frmmasaEkle : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmmasaEkle()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Masa m = new Masa();
            m.kisiSayisi = Convert.ToInt32(txtkisiSayisi.Text);
            m.ad = txtmasaAdi.Text; 

            db.Masa.Add(m);
            db.SaveChanges();

            MessageBox.Show(m.ad + "masa başarı ile kaydedilmiştir.");
            txtmasaAdi.Text = "";
            txtkisiSayisi.Text="";
            GridGuncelle();
        }
        public void GridGuncelle()
        {
            var masalistesi = db.Masa.Select(x =>
              new
              {
                  x.masaID,
                  x.ad,
                  x.kisiSayisi
              }).ToList();
            gridmasalar.DataSource = masalistesi;

            txtkisiSayisi.Text = "";
            txtmasaAdi.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void frmmasaEkle_Load(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)gridmasalar.CurrentRow.Cells["masaID"].Value;
            Masa m = db.Masa.Where(mst => id == mst.masaID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(m.ad + " " + " adlı masa silinsin mi?", "Masa Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.Masa.Remove(m);
                db.SaveChanges();
                MessageBox.Show(m.ad + " " + "adlı masa silindi. ");


                GridGuncelle();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Masa m = db.Masa.Where(x => x.masaID == masaid).SingleOrDefault();

            m.ad = txtmasaAdi.Text;
            m.kisiSayisi = Convert.ToInt32(txtkisiSayisi.Text);
            db.SaveChanges();
            GridGuncelle();
        }
        int masaid;
        void verileriDoldur()
        {
            masaid = Convert.ToInt32(gridmasalar.CurrentRow.Cells["masaID"].Value.ToString());
            var veri = db.Masa.Where(x => masaid == x.masaID).SingleOrDefault();

            txtkisiSayisi.Text = Convert.ToString(veri.kisiSayisi);
            txtmasaAdi.Text = veri.ad;



        }

        private void gridmasalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();

        }
    }
}

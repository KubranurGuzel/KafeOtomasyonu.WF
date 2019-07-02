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
    public partial class frmkategori : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmkategori()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.icerik = txtkadi.Text;

            db.Kategori.Add(k);
            db.SaveChanges();

            MessageBox.Show(k.icerik + "kategori   başarı ile kaydedilmiştir.");
            txtkadi.Text = "";
            GridGuncelle();
        }

        public void GridGuncelle()
        {
            var kategorilistesi = db.Kategori.Select(x =>
              new
              {
                  x.kategoriID,
                  x.icerik
              }).ToList();
            gridkategori.DataSource = kategorilistesi;

            txtkadi.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)gridkategori.CurrentRow.Cells["kategoriID"].Value;
            Kategori k = db.Kategori.Where(mst => id == mst.kategoriID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(k.icerik + " " + "adlı ödeme tipi silinsin mi?", "Ödeme Tip Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.Kategori.Remove(k);
                db.SaveChanges();
                MessageBox.Show(k.icerik + " " + "adlı kategori silindi. ");


                GridGuncelle();
            }
        }

        private void frmkategori_Load(object sender, EventArgs e)
        {
            GridGuncelle(); 
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Kategori k = db.Kategori.Where(x => x.kategoriID ==kategorid ).SingleOrDefault();

            k.icerik =txtkadi.Text;
            db.SaveChanges();
            GridGuncelle();
        }
        int kategorid;
        void verileriDoldur()
        {
            kategorid = Convert.ToInt32(gridkategori.CurrentRow.Cells["kategoriID"].Value.ToString());
            var veri = db.Kategori.Where(x => kategorid == x.kategoriID).SingleOrDefault();

            txtkadi.Text = veri.icerik;


        }

        private void gridkategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();
        }
    }
}

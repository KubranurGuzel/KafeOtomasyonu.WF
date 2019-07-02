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
    public partial class frmodemeekleme : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmodemeekleme()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdemeTip od = new OdemeTip();
            od.icerik = txtodemetip.Text;

            db.OdemeTip.Add(od);
            db.SaveChanges();

            MessageBox.Show(od.icerik + "ödeme tipi  başarı ile kaydedilmiştir.");
            txtodemetip.Text = "";
            GridGuncelle();
        }
        public void GridGuncelle()
        {
            var kullaniciListesi = db.OdemeTip.Select(x =>
              new
              {
                  x.odemeTipID,
                  x.icerik
              }).ToList();
            gridodemetip.DataSource = kullaniciListesi;

            txtodemetip.Text = "";

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            int id = 0;
            id = (int)gridodemetip.CurrentRow.Cells["odemeTipID"].Value;
            OdemeTip od = db.OdemeTip.Where(mst => id == mst.odemeTipID).SingleOrDefault();
            DialogResult deger = MessageBox.Show(od.icerik + " " + "adlı ödeme tipi silinsin mi?", "Ödeme Tip Silme Onayı", MessageBoxButtons.OKCancel);
            if (deger == DialogResult.OK)
            {
                db.OdemeTip.Remove(od);
                db.SaveChanges();
                MessageBox.Show(od.icerik + " " + "adlı ödeme tipi silindi. ");


                GridGuncelle();
            }
        }

        private void frmodemeekleme_Load(object sender, EventArgs e)
        {
            GridGuncelle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            OdemeTip od = db.OdemeTip.Where(x => x.odemeTipID == odemeid).SingleOrDefault();
       
            od.icerik = txtodemetip.Text;
            db.SaveChanges();
            GridGuncelle();
        }
        int odemeid;
        void verileriDoldur()
        {
            odemeid = Convert.ToInt32(gridodemetip.CurrentRow.Cells["odemetipID"].Value.ToString());
            var veri = db.OdemeTip.Where(x => odemeid == x.odemeTipID).SingleOrDefault();
          
            txtodemetip.Text = Convert.ToString(veri.icerik);
        

        }

        private void gridodemetip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verileriDoldur();
        }
    }
}

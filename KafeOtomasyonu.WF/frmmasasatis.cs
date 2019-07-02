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
    public partial class frmmasasatis : Form
    {
        cafeVTContext db = new cafeVTContext();
        public frmmasasatis()
        {
            InitializeComponent();
            
        }
        public void masa()
        {
            panelMasalar.Controls.Clear();
            var masalar = db.Masa.ToList();
            foreach (Masa item in masalar)
            {
                var adisyon = db.Adisyon.Where(x => x.acikMi == true && item.masaID == x.masaID).SingleOrDefault();
                Button b = new Button();
                b.Text = item.ad + Environment.NewLine + "Kişi sayısı: " + item.kisiSayisi;
                if (adisyon != null)
                {
                    b.Text += Environment.NewLine + "toplam" + adisyon.ucret;
                    b.BackColor = Color.Green;


                }
              
                
                b.Size = new Size(100, 100);
                panelMasalar.Controls.Add(b);
            }
        }

      

        public void frmmasasatis_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            masa();            
        }

        private void panelMasalar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

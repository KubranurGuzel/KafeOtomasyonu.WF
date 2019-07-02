using KafeOtomasyonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu.WF
{
    static class Program
    {
      

        public static Kullanici kullanici = new Kullanici();
        public static Kullanici AktifKullanici;
        public static Kategori kategori;
        public static OdemeTip Odeme;
        public static Urun Urun;
        public static stok Stok;
        public static menu Menu;
        public static Masa Masa;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmsiparis());
        }
    }
}

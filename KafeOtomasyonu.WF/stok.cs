//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KafeOtomasyonu.WF
{
    using System;
    using System.Collections.Generic;
    
    public partial class stok
    {
        public int stokID { get; set; }
        public int kategoriID { get; set; }
        public int ustkategoriID { get; set; }
        public int urunID { get; set; }
        public decimal miktar { get; set; }
        public string birim { get; set; }
        public decimal birimFiyat { get; set; }
        public string toplamFiyat { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        public virtual Urun Urun { get; set; }
    }
}

namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Siparis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal siparisID { get; set; }

        public decimal adisyonID { get; set; }

        public decimal urunID { get; set; }

        public int miktar { get; set; }

        public decimal miktarTurID { get; set; }

        public virtual Adisyon Adisyon { get; set; }

        public virtual MiktarTur MiktarTur { get; set; }

        public virtual Urun Urun { get; set; }
    }
}

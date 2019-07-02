namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adisyon")]
    public partial class Adisyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adisyon()
        {
            Siparis = new HashSet<Siparis>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal adisyonID { get; set; }

        public decimal masaID { get; set; }

        public decimal kullaniciID { get; set; }

        public DateTime tarih { get; set; }

        public DateTime kapanmaTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal ucret { get; set; }

        public decimal odemetipID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Masa Masa { get; set; }

        public virtual OdemeTip OdemeTip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}

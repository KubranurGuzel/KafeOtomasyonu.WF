namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urun")]
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            Siparis = new HashSet<Siparis>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal urunID { get; set; }

        public decimal kategoriID { get; set; }

        [Required]
        [StringLength(30)]
        public string adi { get; set; }

        [Column(TypeName = "money")]
        public decimal fiyat { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}

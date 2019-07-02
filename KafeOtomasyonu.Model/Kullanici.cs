namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Adisyon = new HashSet<Adisyon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal kullaniciID { get; set; }

        [Required]
        [StringLength(30)]
        public string adi { get; set; }

        [Required]
        [StringLength(30)]
        public string soyadi { get; set; }

        [Required]
        [StringLength(30)]
        public string eposta { get; set; }

        [Required]
        [StringLength(10)]
        public string sifre { get; set; }

        [Required]
        [StringLength(30)]
        public string yetki { get; set; }

        public decimal kullaniciTC { get; set; }

        [Required]
        [StringLength(50)]
        public string adres { get; set; }

        public decimal cepTel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon { get; set; }
    }
}

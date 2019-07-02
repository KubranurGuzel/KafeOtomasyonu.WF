namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasaTip")]
    public partial class MasaTip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasaTip()
        {
            Masa = new HashSet<Masa>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal masaTipID { get; set; }

        public int icerik { get; set; }

        [Required]
        [StringLength(30)]
        public string resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Masa> Masa { get; set; }
    }
}

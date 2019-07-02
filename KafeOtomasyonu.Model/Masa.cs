namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masa")]
    public partial class Masa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Masa()
        {
            Adisyon = new HashSet<Adisyon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal masaID { get; set; }

        public decimal masaTipID { get; set; }

        public int kisiSayisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon { get; set; }

        public virtual MasaTip MasaTip { get; set; }
    }
}

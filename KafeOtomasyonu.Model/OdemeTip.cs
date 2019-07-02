namespace KafeOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OdemeTip")]
    public partial class OdemeTip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OdemeTip()
        {
            Adisyon = new HashSet<Adisyon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal odemeTipID { get; set; }

        public int icerik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon { get; set; }
    }
}

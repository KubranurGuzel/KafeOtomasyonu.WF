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
    
    public partial class Masa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Masa()
        {
            this.Adisyon = new HashSet<Adisyon>();
            this.Adisyon1 = new HashSet<Adisyon>();
        }
    
        public int masaID { get; set; }
        public int masaTipID { get; set; }
        public int kisiSayisi { get; set; }
        public string ad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon1 { get; set; }
        public virtual MasaTip MasaTip { get; set; }
    }
}

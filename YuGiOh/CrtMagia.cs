//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YuGiOh
{
    using System;
    using System.Collections.Generic;
    
    public partial class CrtMagia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrtMagia()
        {
            this.Tipoes = new HashSet<Tipo>();
        }
    
        public int IdMagia { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Index { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tipo> Tipoes { get; set; }
    }
}

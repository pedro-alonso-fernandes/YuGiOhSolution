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
    
    public partial class CrtImagem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrtImagem()
        {
            this.Cartas = new HashSet<Carta>();
        }
    
        public int IdImagem { get; set; }
        public string Nome { get; set; }
        public string Src { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carta> Cartas { get; set; }
    }
}

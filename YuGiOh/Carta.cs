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
    
    public partial class Carta
    {
        public int IdCarta { get; set; }
        public string Nome { get; set; }
        public Nullable<int> Nivel { get; set; }
        public int Numero { get; set; }
        public Nullable<int> PtnAtaque { get; set; }
        public Nullable<int> PtnDefesa { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> AtributoId { get; set; }
        public Nullable<int> IconeId { get; set; }
        public int TipoId { get; set; }
    
        public virtual Atributo Atributo { get; set; }
        public virtual Icone Icone { get; set; }
        public virtual Tipo Tipo { get; set; }
    }
}
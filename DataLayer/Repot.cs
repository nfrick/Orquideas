//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repot()
        {
            this.Container = 1;
        }
    
        public int RepotID { get; set; }
        public int OrquideaID { get; set; }
        public System.DateTime Data { get; set; }
        public byte Container { get; set; }
        public bool Xaxim { get; set; }
        public bool Pinus { get; set; }
        public bool CascaPinus { get; set; }
        public bool TroncoCentral { get; set; }
        public bool Sphagnum { get; set; }
        public bool Carvao { get; set; }
        public bool TerraVegetal { get; set; }
        public bool Areia { get; set; }
    
        public virtual Orquidea Orquidea { get; set; }
        public virtual ContainerType ContainerType { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISW2PDT5
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_nota_credito
    {
        public tipo_nota_credito()
        {
            this.nota_credito = new HashSet<nota_credito>();
        }
    
        public int id_tipo_nota_credito { get; set; }
    
        public virtual ICollection<nota_credito> nota_credito { get; set; }
    }
}

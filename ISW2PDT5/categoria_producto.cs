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
    
    public partial class categoria_producto
    {
        public categoria_producto()
        {
            this.productoes = new HashSet<producto>();
        }
    
        public int id_categoria_producto { get; set; }
        public string cat_descripcion { get; set; }
    
        public virtual ICollection<producto> productoes { get; set; }
    }
}

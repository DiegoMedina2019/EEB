//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EEB.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class compra
    {
        public compra()
        {
            this.linea_de_compra = new HashSet<linea_de_compra>();
        }
    
        public int id_compra { get; set; }
        public System.DateTime fecha { get; set; }
        public double precio_unitario { get; set; }
        public double itcCompra { get; set; }
        public int USUARIO_id_usuario { get; set; }
        public int PROVEEDOR_id_proveedor { get; set; }
        public string estado { get; set; }
    
        public virtual proveedor proveedor { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual ICollection<linea_de_compra> linea_de_compra { get; set; }
    }
}

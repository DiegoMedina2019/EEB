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
    
    public partial class linea_de_compra
    {
        public int id_linea_caja { get; set; }
        public int cantidad { get; set; }
        public double precio_compra { get; set; }
        public double itcCompra { get; set; }
        public int COMPRA_id_compra { get; set; }
        public int ARTICULO_id_articulo { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual compra compra { get; set; }
    }
}

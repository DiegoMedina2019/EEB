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
    
    public partial class deposito
    {
        public deposito()
        {
            this.stock_deposito = new HashSet<stock_deposito>();
        }
    
        public int id_deposito { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<stock_deposito> stock_deposito { get; set; }
    }
}
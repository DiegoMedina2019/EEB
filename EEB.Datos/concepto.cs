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
    
    public partial class concepto
    {
        public concepto()
        {
            this.linea_de_liquidacion = new HashSet<linea_de_liquidacion>();
        }
    
        public int id_concepto { get; set; }
        public string tipo_concepto { get; set; }
        public string descripcion { get; set; }
        public double importe { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<linea_de_liquidacion> linea_de_liquidacion { get; set; }
    }
}
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
    
    public partial class camion
    {
        public camion()
        {
            this.logistica = new HashSet<logistica>();
        }
    
        public int id_Camion { get; set; }
        public string Descripcion { get; set; }
        public int capacidad { get; set; }
        public int cantidad_cisternas { get; set; }
        public string patente { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<logistica> logistica { get; set; }
    }
}
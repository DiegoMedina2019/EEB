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
    
    public partial class categoria
    {
        public categoria()
        {
            this.empleado = new HashSet<empleado>();
        }
    
        public int id_categoria { get; set; }
        public string descripcion { get; set; }
        public string sindicato { get; set; }
        public string convenio_laboral { get; set; }
        public double sueldo_basico { get; set; }
        public string tipo_sueldo { get; set; }
    
        public virtual ICollection<empleado> empleado { get; set; }
    }
}

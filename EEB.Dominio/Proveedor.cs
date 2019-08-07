using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEB.Datos;

namespace EEB.Dominio
{
    public class Proveedor
    {
        public string cuit { get; set; }
        private static Proveedor datos;
        private ProveedorEntidad proveedorEntidad;

        public Proveedor()
        {
            proveedorEntidad = new ProveedorEntidad();
        }

        public static Proveedor Instance()
        {
            if (datos == null)
            {
                datos = new Proveedor();
            }
            return datos;
        }

        public string Create(params object[] array)
        {
            proveedorEntidad.CrearProveedor(array);
            return "";
        }
        public proveedor Edit(string cuit)
        {
            return proveedorEntidad.ObtenerProveedorPorCuit(cuit);
        }
        /*Grilla que se personalizara de acuerdo a los atributos*/
        public IEnumerable<object> ObtenerGrilla()
        {
            return proveedorEntidad.VerGrilla();
        }
        public List<string> ValueComboBox(string type_search,string province)
        {
            List<string> result = new List<string>();
            switch(type_search)
            {
                case "CONDICIÓN DE IVA":
                    result = proveedorEntidad.ComboBoxCondicionIva();
                    break;
                case "PROVINCIA":
                    result = proveedorEntidad.ComboBoxProvincia();
                    break;
                case "LOCALIDAD":
                    result =proveedorEntidad.ComboBoxLocalidad(province);
                    break;
                case "ESTADO":
                    result = proveedorEntidad.ComboBoxEstado();
                    break;
            }
            return result.ToList();
            
        }
        public List<object> ViewDetails(string cuit)
        {
            return proveedorEntidad.ObtenerDetalles(cuit);
        }
        public string CodePostal(string distrito)
        {
            return proveedorEntidad.ObtenerCodigoPostal(distrito);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEB.Datos
{
    public class ProveedorEntidad
    {
        private List<object> lista = new List<object>();
        private List<string> l = new List<string>();
        private List<string> listado_condiciones = new List<string>();
        private List<string> listado_provincia = new List<string>();
        private List<string> listado_localidad = new List<string>();
        private List<string> listado_estado = new List<string>();

        #region Verificar Existencia del Proveedor
        public List<object> ObtenerDetalles(string cuit)
        {
            using (eebEntities eeb = new eebEntities())
            {
                var query = (from p in eeb.proveedor
                            where p.cuit ==  cuit
                            select new
                            {
                                cuit = p.cuit,
                                razon_social = p.razon_social,
                            });
               foreach(var item in query)
               {
                    lista.Add(item);
               }
                return lista.ToList();
            }
            
        }
        #endregion

        #region Crear,Editar,Eliminar Proveedor
        public string CrearProveedor(params object[] lista)
        {
            try
            {
                using (eebEntities eeb = new eebEntities())
                {
                    proveedor _proveedor = new proveedor();
                    ubicacion _ubicacion = new ubicacion();

                    for(int i=0; i<lista.Length;i=17)
                    {
                        _proveedor.id_proveedor = ObtenerIDProveedor() + 1;
                        _proveedor.cuit = Convert.ToString(lista[i]);
                        _proveedor.razon_social = Convert.ToString(lista[i+1]);
                        _proveedor.nombre_contacto = Convert.ToString(lista[i+2]);
                        _proveedor.CONDICION_DE_IVA_id_condicion_iva = ObtenerIDCondicionIva(Convert.ToString(lista[i+3]));
                        _proveedor.telefono_fijo = Convert.ToString(lista[i+4]);
                        _proveedor.celular = Convert.ToString(lista[i+5]);
                        _proveedor.email = Convert.ToString(lista[i+6]);
                        _proveedor.estado = Convert.ToString(lista[i+7]);
                        _proveedor.PROVINCIA_id_provincia = ObtenerIDProvincia(Convert.ToString(lista[i+8]));
                        _proveedor.fecha_registro = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        _ubicacion.id_ubicacion = ObtenerIDUbicacion() + 1;
                        _ubicacion.LOCALIDAD_id_localidad = ObtenerIDLocalidad(Convert.ToString(lista[i+9]));
                        _ubicacion.calle = Convert.ToString(lista[i + 10]);
                        _ubicacion.barrio = Convert.ToString(lista[i + 11]);
                        /*Corregir casa*/
                        _ubicacion.casa = 0;
                        _ubicacion.manzana = Convert.ToString(lista[i + 13]);
                        _ubicacion.zona = Convert.ToString(lista[i + 14]);
                        _ubicacion.sector = Convert.ToString(lista[i + 15]);
                        _ubicacion.piso = Convert.ToString(lista[i + 16]);
                        _ubicacion.departamento = Convert.ToString(lista[i + 17]);
                        eeb.proveedor.Add(_proveedor);
                        eeb.ubicacion.Add(_ubicacion);
                        eeb.SaveChanges();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string EditarProveedor(params object[] lista)
        {
            try
            {
                using (eebEntities eeb = new eebEntities())
                {
                    proveedor _proveedor = new proveedor();
                    for (int i = 0; i < lista.Length; i = 11)
                    {
                        _proveedor.id_proveedor = Convert.ToInt32(lista[i]);
                        _proveedor.cuit = Convert.ToString(lista[i + 1]);
                        _proveedor.razon_social = Convert.ToString(lista[i + 2]);
                        _proveedor.nombre_contacto = Convert.ToString(lista[i + 3]);
                        _proveedor.telefono_fijo = Convert.ToString(lista[i + 4]);
                        _proveedor.celular = Convert.ToString(lista[i + 5]);
                        _proveedor.email = Convert.ToString(lista[i + 6]);
                        _proveedor.fecha_registro = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        _proveedor.CONDICION_DE_IVA_id_condicion_iva = Convert.ToInt32(lista[i + 8]);
                        _proveedor.PROVINCIA_id_provincia = 1;
                        _proveedor.estado = Convert.ToString(lista[i + 9]);
                        eeb.proveedor.Add(_proveedor);
                        eeb.SaveChanges();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string EliminarProveedor(params object[] lista)
        {
            try
            {
                using (eebEntities eeb = new eebEntities())
                {
                    proveedor _proveedor = new proveedor();
                    for (int i = 0; i < lista.Length; i = 11)
                    {
                        _proveedor.id_proveedor = Convert.ToInt32(lista[i]);
                        _proveedor.cuit = Convert.ToString(lista[i + 1]);
                        _proveedor.razon_social = Convert.ToString(lista[i + 2]);
                        _proveedor.nombre_contacto = Convert.ToString(lista[i + 3]);
                        _proveedor.telefono_fijo = Convert.ToString(lista[i + 4]);
                        _proveedor.celular = Convert.ToString(lista[i + 5]);
                        _proveedor.email = Convert.ToString(lista[i + 6]);
                        _proveedor.fecha_registro = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        _proveedor.CONDICION_DE_IVA_id_condicion_iva = Convert.ToInt32(lista[i + 8]);
                        _proveedor.PROVINCIA_id_provincia = 1;
                        _proveedor.estado = Convert.ToString(lista[i + 9]);
                        eeb.proveedor.Add(_proveedor);
                        eeb.SaveChanges();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion  

        #region Obtener Grilla Sin Filtro
        public IEnumerable<object> VerGrilla()
        {
            using (eebEntities eeb = new eebEntities())
            {
                var query = (from prove in eeb.proveedor
                             join condicionIva in eeb.condicion_de_iva on prove.CONDICION_DE_IVA_id_condicion_iva equals condicionIva.id_condicion_iva
                             join provi in eeb.provincia on prove.PROVINCIA_id_provincia equals provi.id_provincia
                             join locali in eeb.localidad on provi.id_provincia equals locali.PROVINCIA_id_provincia
                             select new
                             {
                                 prove.cuit,
                                 prove.razon_social,
                                 prove.nombre_contacto,
                                 condicionIva.descripción,
                                 prove.telefono_fijo,
                                 prove.celular,
                                 prove.email,
                                 provi.descripcion,
                                 locali.nombre,
                                 prove.fecha_registro,
                                 prove.estado
                             });
                return query.ToList();
            }
        }
        #endregion

        #region ComboBox para Condicion de Iva,Provincia,Localidad
        public List<string>ComboBoxCondicionIva()
        {
            using (eebEntities eeb = new eebEntities())
            {
                var query = eeb.condicion_de_iva.Select(s => s.descripción);
                foreach(var i in query)
                {
                    if(!(listado_condiciones.Contains(i)))
                    {
                        listado_condiciones.Add(i);
                    }
                }
            }
            return listado_condiciones.ToList();
        }
        public List<string> ComboBoxProvincia()
        {
            using (eebEntities eeb = new eebEntities())
            {
                var query = eeb.provincia.Select(s => s.descripcion);
                foreach (var i in query)
                {
                    if (!(listado_provincia.Contains(i)))
                    {
                        listado_provincia.Add(i);
                    }
                }
            }
            return listado_provincia.ToList();
        }
        public List<string> ComboBoxLocalidad(string provincia)
        {
            using (eebEntities eeb = new eebEntities())
            {
                int id_provincia = ObtenerIDProvincia(provincia);
                var query = (from provin in eeb.provincia
                             join localid in eeb.localidad on provin.id_provincia equals localid.PROVINCIA_id_provincia
                             where localid.PROVINCIA_id_provincia == id_provincia
                             select localid.nombre);
                listado_localidad = query.ToList();
            }
            return listado_localidad.Select(i=>i).Distinct().ToList();
        }
        public List<string> ComboBoxEstado()
        {
            using (eebEntities eeb = new eebEntities())
            {
                var query = eeb.proveedor.Select(s => s.estado);
                foreach (var i in query)
                {
                    if (!(listado_estado.Contains(i)))
                    {
                        listado_estado.Add(i);
                    }
                }
            }
            return listado_estado.ToList();
        }
        #endregion

        #region Obtener
        public int ObtenerIDProvincia(string provincia)
        {
            int provinciaID = 0;
            using (eebEntities eeb = new eebEntities())
            {
                var query = from p in eeb.provincia
                                       where p.descripcion == provincia
                                       select new
                                       {
                                           _idprovincia = p.id_provincia
                                       };
                foreach (var p in query)
                {
                    provinciaID = p._idprovincia;
                }
            }
            return provinciaID;
        }
        public int ObtenerIDProveedor()
        {
            int proveedorID = 0;
            using (eebEntities eeb = new eebEntities())
            {
                var query = from p in eeb.proveedor
                            select new
                            {
                                p.id_proveedor
                            };
                foreach(var p in query)
                {
                    proveedorID = p.id_proveedor;
                }
            }
            return proveedorID;
        }
        public int ObtenerIDCondicionIva(string condicion_iva)
        {
            int condicionID = 0;
            using (eebEntities eeb = new eebEntities())
            {
                var query = from c in eeb.condicion_de_iva
                            where c.descripción == condicion_iva
                            select new
                            {
                                c.id_condicion_iva
                            };
                foreach (var p in query)
                {
                    condicionID = p.id_condicion_iva;
                }
            }
            return condicionID;
        }
        public int ObtenerIDUbicacion()
        {
            int ubicacionID = 0;
            using (eebEntities eeb = new eebEntities())
            {
                var query = from u in eeb.ubicacion
                            select new
                            {
                                u.id_ubicacion
                            };
                foreach (var u in query)
                {
                    ubicacionID = u.id_ubicacion;
                }
            }
            return ubicacionID;
        }
        public int ObtenerIDLocalidad(string localidad)
        {
            int localidadID = 0;
            using (eebEntities eeb = new eebEntities())
            {
                var query = from c in eeb.localidad
                            where c.nombre == localidad
                            select new
                            {
                                c.id_localidad
                            };
                foreach (var c in query)
                {
                    localidadID = c.id_localidad;
                }
            }
            return localidadID;
        }
        public string ObtenerCodigoPostal(string localidad)
        {
            string codigo = string.Empty;
            using (eebEntities eeb = new eebEntities())
            {
                var query = from cp in eeb.localidad
                            where cp.nombre == localidad
                            select new
                            {
                                cp.codigo_postal
                            };
                foreach (var c in query)
                {
                    codigo = c.codigo_postal;
                }
            }
            return codigo;
        }
        public proveedor ObtenerProveedorPorCuit(string cuit)
        {
            proveedor p = new proveedor();
            using (eebEntities eeb = new eebEntities())
            {
                p = eeb.proveedor.Where(s => s.cuit == cuit).FirstOrDefault();
            }
            return p;
        }
        #endregion
    }
}

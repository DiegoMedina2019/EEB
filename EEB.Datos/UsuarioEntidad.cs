using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEB.Datos
{
    public class UsuarioEntidad
    {
        public string ExisteUsuario(string username,string password)
        {
            try
            {
                string mensaje = string.Empty;
                using (eebEntities eeb = new eebEntities())
                {
                    var existe_usuario = eeb.usuario.Any(u => u.nombre_usario == username);
                    var existe_contraseña = eeb.usuario.Any(u => u.contraseña == password);
                    
                    if(existe_usuario == false && existe_contraseña == false) { mensaje="USUARIO INCORRECTO Y CONTRASEÑA INCORRECTA"; }
                    if(existe_usuario == true && existe_contraseña == false) { mensaje="USUARIO CORRECTO PERO CONTRASEÑA INCORRECTA"; }
                    if(existe_usuario == false && existe_contraseña == true) { mensaje="CONTRASEÑA CORRECTA PERO USUARIO INCORRECTO"; }
                    if(existe_usuario == true && existe_contraseña == true)
                    {
                        var query = (from u in eeb.usuario
                                     where u.nombre_usario == username && u.contraseña == password
                                     select new { u.nombre_usario, u.contraseña});
                        if(query != null)
                        {
                            mensaje="EXISTE";
                        }
                        else
                        {
                            mensaje="NO EXISTE";
                        }
                    }
                }
                return mensaje;
            }
            catch(Exception ex)
            {
                var error = ex.ToString();
                return "NO ESTA CONECTADO A LA BASE DE DATOS";
            }
        }
    }
}

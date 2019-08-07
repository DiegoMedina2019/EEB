using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEB.Datos
{
    public class UsuarioEntidad
    {
        private string mensaje;

        public string ExisteUsuario(string username,string password)
        {
            try
            {
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

        public string CambioContraseña(int id_usuario, string estado, string username, string contraseña_anterior, string nueva_contraseña)
        {
            try
            {
                using (eebEntities eeb = new eebEntities())
                {
                    usuario user = eeb.usuario.FirstOrDefault(u => u.nombre_usario == username && u.contraseña == contraseña_anterior);
                    if (user != null)
                    {
                        user.id_usuario = id_usuario;
                        user.nombre_usario = username;
                        user.estado = estado;
                        user.contraseña = nueva_contraseña;
                        eeb.SaveChanges();
                        mensaje = "CONTRASEÑA FUE CAMBIADA EXITOSAMENTE";
                    }
                    else
                    {
                        mensaje = "NO SE PUDO CAMBIAR LA CONTRASEÑA";
                    }
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #region Obtener Datos Previos
        public int ObtenerIdUsuario(string username)
        {
            int userID = 0;
            using (eebEntities eeb = new eebEntities())
            {
                var consulta_usuario = from user in eeb.usuario
                                       where user.nombre_usario == username
                                       select new
                                       {
                                           _iduser = user.id_usuario
                                       };
                foreach (var u in consulta_usuario)
                {
                    userID = u._iduser;
                }
            }
            return userID;
        }

        public string ObtenerEstadoUsuario(string username)
        {
            string userstate=string.Empty;
            using (eebEntities eeb = new eebEntities())
            {
                var consulta = eeb.usuario.Where(u => u.nombre_usario == username).Select(u => u.estado);
                mensaje = string.Join("", consulta);
            }
            return mensaje;
        }

        public string ObternerContraseñaActual(string username)
        {
            using (eebEntities eeb = new eebEntities())
            {
                var consulta = eeb.usuario.Where(u => u.nombre_usario == username).Select(u => u.contraseña);
                mensaje = string.Join("", consulta);
            }
            return mensaje;
        }
        #endregion
    }
}

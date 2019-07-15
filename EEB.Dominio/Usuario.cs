using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEB.Datos;

namespace EEB.Dominio
{
    public class Usuario
    {
        string mensaje = string.Empty;

        public string _username { get; set; }
        private static Usuario datos;
        private UsuarioEntidad usuarioEntidad;
        
        public Usuario()
        {
            usuarioEntidad = new UsuarioEntidad();
        }
        public static Usuario Instance()
        {
            if (datos == null)
            {
                datos = new Usuario();
            }
            return datos;
        }
        public string Login(string username,string password)
        {
            return mensaje = usuarioEntidad.ExisteUsuario(username, password);
        }
        public string ChangePassword(string username, string oldpassword,string newpassword)
        {
            int id_usuario = usuarioEntidad.ObtenerIdUsuario(username);
            string estado = usuarioEntidad.ObtenerEstadoUsuario(username);
            return usuarioEntidad.CambioContraseña(id_usuario, estado, username,oldpassword, newpassword);
        }
        public string PassawordCurrent(string username)
        {
            return usuarioEntidad.ObternerContraseñaActual(username);
        }
    }
}

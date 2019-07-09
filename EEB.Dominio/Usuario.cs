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

        private UsuarioEntidad usuarioEntidad;
        
        public Usuario()
        {
            usuarioEntidad = new UsuarioEntidad();
        }
        public string Login(string username,string password)
        {
            return mensaje = usuarioEntidad.ExisteUsuario(username, password);
        }
    }
}

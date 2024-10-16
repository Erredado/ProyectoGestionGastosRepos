using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IniciarSesion(string username, string password)
        {
            return Username == username && Password == password;
        }

        public void CerrarSesion()
        {
            Console.WriteLine("Sesión cerrada.");
        }

        public void CambiarContraseña(string nuevaPassword)
        {
            Password = nuevaPassword;
        }

        public void AsignarRol(string rol)
        {
            Rol = rol;
        }

    }
}

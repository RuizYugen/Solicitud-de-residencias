using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelos
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string rol { get; set; }

        public Usuario() { }
        public Usuario(string usuario, string contrasena, string rol)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
        }
    }
}

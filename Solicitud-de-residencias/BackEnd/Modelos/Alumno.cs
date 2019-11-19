using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelos
{
    public class Alumno
    {

        //Comentario
        public string noControl { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string carrera { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public string ciudad { get; set; }
        public string servicioSalud { get; set; }
        public string numeroServicioSalud { get; set; }
        public string asesorInterno { get; set; }
        public Alumno() { }

        public Alumno(string noControl, string usuario, string nombre, string apellidoPaterno, string apellidoMaterno, string carrera, string email, string telefono, string domicilio, string ciudad, string servicioSalud, string numeroServicioSalud)
        {
            this.noControl = noControl;
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.carrera = carrera;
            this.email = email;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.ciudad = ciudad;
            this.servicioSalud = servicioSalud;
            this.numeroServicioSalud = numeroServicioSalud;
        }

    }
}

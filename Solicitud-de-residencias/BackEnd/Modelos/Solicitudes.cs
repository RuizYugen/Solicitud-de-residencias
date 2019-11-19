using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelos
{
    public class Solicitudes
    {
        public int idSolicitud { get; set; }
        public string noControl { get; set; }
        public string nombre { get; set; }
        public Boolean estado { get; set; }

        public Solicitudes() { }

        public Solicitudes(int idSolicitud, string noControl, string nombre, Boolean estado)
        {
            this.idSolicitud = idSolicitud;
            this.noControl = noControl;
            this.nombre = nombre;
            this.estado = estado;

        }

    }
}

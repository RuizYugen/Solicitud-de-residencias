using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelos
{
    public class DetallesSolicitud
    {
        public int idSolicitud { get; set; }
        public string noControl { get; set; }
        public string lugar { get; set; }
        public DateTime fecha { get; set; }
        public string coordinadorCarrera { get; set; }
        public string nombreProyecto { get; set; }
        public string opcionElegida { get; set; }
        public string periodo { get; set; }
        public int numeroResidentes { get; set; }
        public string nombreEmpresa { get; set; }
        public string giro { get; set; }
        public string sector { get; set; }
        public string rfc { get; set; }
        public string domicilioEmpresa { get; set; }
        public string coloniaEmpresa { get; set; }
        public string cpEmpresa { get; set; }
        public string faxEmpresa { get; set; }
        public string ciudadEmpresa { get; set; }
        public string telefonoEmpresa { get; set; }
        public string misionEmpresa { get; set; }
        public string nombreTitularEmpresa { get; set; }
        public string puestoTitularEmpresa { get; set; }
        public string nombreAsesorExterno { get; set; }
        public string puestoAsesorExterno { get; set; }
        public string nombreAcuerdoTrabajo { get; set; }
        public string puestoAcuerdoTrabajo { get; set; }
        public string nombreResidente { get; set; }

        public DetallesSolicitud() { }

        public DetallesSolicitud(int idSolicitud, string noControl, string lugar, DateTime fecha, string coordinadorCarrera, string nombreProyecto, string opcionElegida, string periodo, int numeroResidentes, string nombreEmpresa, string giro, string sector, string rfc, string domicilioEmpresa, string coloniaEmpresa, string cpEmpresa, string faxEmpresa, string ciudadEmpresa, string telefonoEmpresa, string misionEmpresa, string nombreTitularEmpresa, string puestoTitularEmpresa, string nombreAsesorExterno, string puestoAsesorExterno, string nombreAcuerdoTrabajo, string puestoAcuerdoTrabajo, string nombreResidente)
        {
            this.idSolicitud = idSolicitud;
            this.noControl = noControl;
            this.lugar = lugar;
            this.fecha = fecha;
            this.coordinadorCarrera = coordinadorCarrera;
            this.nombreProyecto = nombreProyecto;
            this.opcionElegida = opcionElegida;
            this.periodo = periodo;
            this.numeroResidentes = numeroResidentes;
            this.nombreEmpresa = nombreEmpresa;
            this.giro = giro;
            this.sector = sector;
            this.rfc = rfc;
            this.domicilioEmpresa = domicilioEmpresa;
            this.coloniaEmpresa = coloniaEmpresa;
            this.cpEmpresa = cpEmpresa;
            this.faxEmpresa = faxEmpresa;
            this.ciudadEmpresa = ciudadEmpresa;
            this.telefonoEmpresa = telefonoEmpresa;
            this.misionEmpresa = misionEmpresa;
            this.nombreTitularEmpresa = nombreTitularEmpresa;
            this.puestoTitularEmpresa = puestoTitularEmpresa;
            this.nombreAsesorExterno = nombreAsesorExterno;
            this.puestoAsesorExterno = puestoAsesorExterno;
            this.nombreAcuerdoTrabajo = nombreAcuerdoTrabajo;
            this.puestoAcuerdoTrabajo = puestoAcuerdoTrabajo;
            this.nombreResidente = nombreResidente;
        }
    }
}

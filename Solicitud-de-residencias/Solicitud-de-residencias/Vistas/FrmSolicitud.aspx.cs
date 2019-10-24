using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BackEnd.DAOS;
using BackEnd.Modelos;

namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmSolicitud : System.Web.UI.Page
    {

        int idSolicitud = 0;
        String lugar = "";
        String fechaStr = "";
        String coordinadorCarrera = "";
        String nombreProyectoS = "";
        String opcionElegida = "";
        String periodoStr = "";
        int numeroResidentes = 0;
        String nombreEmpresaStr = "";
        String giro = "";
        String sector = "";
        String rfc = "";
        String domicilioEmpresa = "";
        String coloniaEmpresa = "";
        String cpEmpresa = "";
        String faxEmpresa = "";
        String ciudadEmpresa = "";
        String telefonoEmpresa = "";
        String misionEmpresa = "";
        String nombreTitularEmpresa = "";
        String puestoTitularEmpresa = "";
        String nombreAsesorExterno = "";
        String puestoAsesorExterno = "";
        String nombreAcuerdoTrabajo = "";
        String puestoAcuerdoTrabajo = "";
        //Datos alumno en la solicitud
        String nombreResidente = "";
        String noControlR = "";
        String carreraStr = "";
        String domicilioStr = "";
        String emailStr = "";
        String ciudad = "";
        String seguro = "";
        String nSeguro = "";
        String telefonoStr = "";
        // Datos del alumno
        static String usuario = "eli";

        //Si ya existe la versión de una solicitud
        Boolean modificar = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            llenarDatos();
            cargarSolicitud();

        }
        public void llenarDatos()
        {
            Alumno a = obtenerAlumno();
            nombreResidente = a.nombre + " " + a.apellidoPaterno + " " + a.apellidoMaterno;
            noControlR = a.noControl;
            carreraStr = a.carrera;
            domicilioStr = a.domicilio;
            emailStr = a.email;
            ciudad = a.ciudad;
            seguro = a.servicioSalud;
            nSeguro = a.numeroServicioSalud;
            telefonoStr = a.telefono;

            this.nombreAlumno.Value = nombreResidente;
            this.noControl.Value = noControlR;
            this.carrera.Value = carreraStr;
            this.domicilioAlu.Value = domicilioStr;
            this.email.Value = emailStr;
            this.ciudadAlu.Value = ciudad;
            this.noSeguro.Value = nSeguro;
            this.teleAlu.Value = telefonoStr;

            if (a.servicioSalud.Equals("IMSS"))
            {
                this.rbImss.Checked = true;
            }
            if (a.servicioSalud.Equals("ISSSTE"))
            {
                this.rbIssste.Checked = true;
            }
            if (a.servicioSalud.Equals("Otros"))
            {
                this.rbOtrosS.Checked = true;
            }

        }
        public void cargarSolicitud()
        {
            DetallesSolicitud ds = new DetallesSolicitud();
            DetallesSolicitudDAO dao = new DetallesSolicitudDAO();
            ds = dao.getDetallesSolicitudByNoControl(noControlR);
            if (ds.noControl != null)
            {
                modificar = true;
                fechaCale2.Text = ds.fecha.ToString("yyyy-MM-dd");
                txtCoordinador.InnerText = ds.coordinadorCarrera;
                txtnombreProyecto.Value = ds.nombreProyecto;
                if (ds.opcionElegida.Equals("Banco de proyectos"))
                {
                    bool b = true;
                    
                    
                    this.rbBanco.Checked = b;
                }
                if (ds.opcionElegida.Equals("Propuesta propia"))
                {
                    this.rbpropia.Checked = true;
                   
                }
                if (ds.opcionElegida.Equals("Trabajador"))
                {
                    this.rbtrabajador.Checked = true;
                }
                this.periodo.Value = ds.periodo;
                this.numResidentes.Value = ds.numeroResidentes + "";
                this.nombreEmpresa.Value = ds.nombreEmpresa;
                if (ds.giro.Equals("Industrial"))
                {
                    this.rbIndus.Checked = true;
                    
                }
                if (ds.giro.Equals("Servicios"))
                {
                    this.rbServ.Checked = true;
                }
                if (ds.giro.Equals("Otro"))
                {
                    this.rbotroG.Checked = true;
                }
                if (ds.sector.Equals( "Público"))
                {
                    this.rbPublico.Checked = true;
                    
                }
                if (ds.sector.Equals("Privado"))
                {
                    this.rbPrivado.Checked = true;
                }
                this.txtRfc.Value = ds.rfc;
                this.domicilioEmp.Value = ds.domicilioEmpresa;
                this.colonia.Value = ds.coloniaEmpresa;
                this.cp.Value = ds.cpEmpresa;
                this.telefonoEmp.Value = ds.telefonoEmpresa;
                this.fax.Value = ds.faxEmpresa;
                this.ciudadEmp.Value = ds.ciudadEmpresa;
                this.mision.Value = ds.misionEmpresa;
                this.titular.Value = ds.nombreTitularEmpresa;
                this.puestoTit.Value = ds.puestoTitularEmpresa;
                this.asesor.Value = ds.nombreAsesorExterno;
                this.puestoAse.Value = ds.puestoAsesorExterno;
                this.acuerdo.Value = ds.nombreAcuerdoTrabajo;
                this.puestoAcue.Value = ds.puestoAcuerdoTrabajo;
            }
            else
            {
               
            }

        }
        public void guardarSolicitud()
        {
            DetallesSolicitud ds = new DetallesSolicitud();
            DetallesSolicitudDAO dao = new DetallesSolicitudDAO();
            List<DetallesSolicitud> lista = dao.getAll();
            int lastId = 0;
            if (lista.Count > 0)
            {
                lastId = lista.ElementAt(lista.Count - 1).idSolicitud;
            }
            else
            {
                lastId = 0;
            }
            
            ds.idSolicitud = lastId+1;
            ds.noControl = noControlR;
            ds.lugar = lugar;
            ds.fecha = DateTime.Parse(fechaStr);
            ds.coordinadorCarrera = coordinadorCarrera;
            ds.nombreProyecto = nombreProyectoS;
            ds.opcionElegida = opcionElegida;
            ds.periodo = periodoStr;
            ds.numeroResidentes = numeroResidentes;
            ds.nombreEmpresa = nombreEmpresaStr;
            ds.giro = giro;
            ds.sector = sector;
            ds.rfc = rfc;
            ds.domicilioEmpresa = domicilioEmpresa;
            ds.coloniaEmpresa = coloniaEmpresa;
            ds.cpEmpresa = cpEmpresa;
            ds.faxEmpresa = faxEmpresa;
            ds.ciudadEmpresa = ciudadEmpresa;
            ds.telefonoEmpresa = telefonoEmpresa;
            ds.misionEmpresa = misionEmpresa;
            ds.nombreTitularEmpresa = nombreTitularEmpresa;
            ds.puestoTitularEmpresa = puestoTitularEmpresa;
            ds.nombreAsesorExterno = nombreAsesorExterno;
            ds.puestoAsesorExterno = puestoAsesorExterno;
            ds.nombreAcuerdoTrabajo = nombreAcuerdoTrabajo;
            ds.puestoAcuerdoTrabajo = puestoAcuerdoTrabajo;
            ds.nombreResidente = nombreResidente;

            dao.insert(ds);

            MsgBox(dao.getAll().Count + "", this.Page, this);

            //  ds.fecha = fechaStr;

            //  MsgBox(ds.fecha.Year.ToString(), this.Page, this);
          //  ds.giro = giro;
          

        }
        public Alumno obtenerAlumno()
        {
            Alumno a=new Alumno();
            AlumnoDAO dao= new AlumnoDAO();
            a = dao.getAlumnoByUsuario(usuario);
            return a;

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            lugar = "Uriangato Gto.";
            fechaStr = fechaCale2.Text.ToString();
            coordinadorCarrera = txtCoordinador.InnerText;//ObtenerCooordinadorCarrera
            nombreProyectoS = txtnombreProyecto.Value.ToString();
            bool banco = this.rbBanco.Checked;
            bool propia = this.rbpropia.Checked;
            bool trabajador = this.rbtrabajador.Checked;
            if (banco)
            {
                opcionElegida = rbBanco.Value.ToString();
            }
            if (propia)
            {

                opcionElegida = rbpropia.Value.ToString();


            }
            if (trabajador)
            {
                opcionElegida = rbtrabajador.Value.ToString();
            }
            periodoStr = this.periodo.Value.ToString();
            String aux = this.numResidentes.Value;
            numeroResidentes = int.Parse(aux);
            nombreEmpresaStr = nombreEmpresa.Value;
            bool industrial = rbIndus.Checked;
            bool servicios = rbServ.Checked;
            bool otros = rbotroG.Checked;
            if (industrial)
            {
                giro = rbIndus.Value;
            }
            if (servicios)
            {
                giro = rbServ.Value;
            }
            if (otros)
            {
                giro = rbtrabajador.Value;
            }


            bool publico = rbPublico.Checked;
            bool privado = rbPrivado.Checked;
            if (publico)
            {
                sector = rbPublico.Value;
            }
            if (privado)
            {
                sector = rbPrivado.Value;
            }
            rfc = this.txtRfc.Value;
            domicilioEmpresa = this.domicilioEmp.Value;
            coloniaEmpresa = this.colonia.Value;
            cpEmpresa = this.cp.Value;
            faxEmpresa = this.fax.Value;
            ciudadEmpresa = this.ciudadEmp.Value;
            telefonoEmpresa = this.telefonoEmp.Value;
            misionEmpresa = this.mision.Value;
            nombreTitularEmpresa = this.titular.Value;
            puestoTitularEmpresa = this.puestoTit.Value;
            nombreAsesorExterno = this.asesor.Value;
            puestoAsesorExterno = this.puestoAse.Value;
            nombreAcuerdoTrabajo = this.acuerdo.Value;
            puestoAcuerdoTrabajo = this.puestoAcue.Value;
            String datos = lugar + " " + fechaStr + " " + coordinadorCarrera + " " + nombreProyectoS + " " + opcionElegida +
                " " + periodoStr + " " + numeroResidentes + " " + nombreEmpresaStr + " " + giro + " " + sector +
                " " + rfc + " " + domicilioEmpresa + " " + coloniaEmpresa + " " + cpEmpresa + " " + faxEmpresa + " " + ciudadEmpresa + " " +
               telefonoEmpresa + " " + misionEmpresa + " " + nombreTitularEmpresa + " " + puestoTitularEmpresa + " " +
               nombreAsesorExterno + " " + puestoAsesorExterno + " " + nombreAcuerdoTrabajo + " " + puestoAcuerdoTrabajo;
            // MsgBox(datos, this.Page, this);
            guardarSolicitud();
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}
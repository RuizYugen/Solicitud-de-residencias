using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BackEnd.DAOS;
using BackEnd.Modelos;
using System.Threading;
using Spire.Pdf;
using Spire.Pdf.HtmlConverter;
using System.IO;

namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmExportarSolicitud : System.Web.UI.Page
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
        static String nombreResidente = "";
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
        static Boolean modificar = false;
        static DetallesSolicitud actualizar;
        static Alumno a;
        protected void Page_Load(object sender, EventArgs e)
        {

                this.rbBanco2.Checked = true;
                this.rbIndus.Checked = true;
                this.rbPublico.Checked = true;
                fechaCale2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                llenarDatos();
                cargarSolicitud();

                //Creamos el delegado 
                ThreadStart delegado = new ThreadStart(PDF);
                //Creamos la instancia del hilo 
                Thread hilo = new Thread(delegado);
                //Iniciamos el hilo 
                hilo.Start();
            
             
               ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
            
        }

      
        public void cargarSolicitud()
        {
            DetallesSolicitud ds = new DetallesSolicitud();
            DetallesSolicitudDAO dao = new DetallesSolicitudDAO();

            try
            {
                ds = dao.getDetallesSolicitudByNoControl(noControlR);

                if (ds.noControl != null)
                {
                    modificar = true;
                    actualizar = new DetallesSolicitud();
                    actualizar = ds;
                    fechaCale2.Text = actualizar.fecha.ToString("yyyy-MM-dd");
                    txtCoordinador.InnerText = actualizar.coordinadorCarrera;
                    txtnombreProyecto.Value = actualizar.nombreProyecto;
                    if (actualizar.opcionElegida.Equals("Banco de proyectos"))
                    {

                        this.rbBanco2.Checked = true;
                        // MsgBox("1", this.Page, this);

                    }
                    if (actualizar.opcionElegida.Equals("Propuesta propia"))
                    {
                        this.rbpropia2.Checked = true;
                        //MsgBox("2", this.Page, this);

                    }
                    if (actualizar.opcionElegida.Equals("Trabajador"))
                    {
                        this.rbtrabajador2.Checked = true;
                        // MsgBox("3", this.Page, this);
                    }
                    this.periodo.Value = actualizar.periodo;
                    this.numResidentes.Value = actualizar.numeroResidentes + "";
                    this.nombreEmpresa.Value = actualizar.nombreEmpresa;
                    if (actualizar.giro.Equals("Industrial"))
                    {
                        this.rbIndus.Checked = true;

                    }
                    if (actualizar.giro.Equals("Servicios"))
                    {
                        this.rbServ.Checked = true;
                    }
                    if (actualizar.giro.Equals("Otro"))
                    {
                        this.rbotroG.Checked = true;
                    }
                    if (actualizar.sector.Equals("Publico"))
                    {
                        this.rbPublico.Checked = true;

                    }
                    if (actualizar.sector.Equals("privado"))
                    {
                        this.rbPrivado.Checked = true;
                    }
                    this.txtRfc.Value = actualizar.rfc;
                    this.domicilioEmp.Value = actualizar.domicilioEmpresa;
                    this.colonia.Value = actualizar.coloniaEmpresa;
                    this.cp.Value = actualizar.cpEmpresa;
                    this.telefonoEmp.Value = actualizar.telefonoEmpresa;
                    this.fax.Value = actualizar.faxEmpresa;
                    this.ciudadEmp.Value = actualizar.ciudadEmpresa;
                    this.mision.Value = actualizar.misionEmpresa;
                    this.titular.Value = actualizar.nombreTitularEmpresa;
                    this.puestoTit.Value = actualizar.puestoTitularEmpresa;
                    this.asesor.Value = actualizar.nombreAsesorExterno;
                    this.puestoAse.Value = actualizar.puestoAsesorExterno;
                    this.acuerdo.Value = actualizar.nombreAcuerdoTrabajo;
                    this.puestoAcue.Value = actualizar.puestoAcuerdoTrabajo;
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

            }


        }
        public void llenarDatos()

        {
            Alumno al = new Alumno();
            AlumnoDAO dao = new AlumnoDAO();
            al = dao.getAlumnoByUsuario(usuario);
            a = new Alumno();
            a = al;
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

        private void PDF()
        {    
            Thread.Sleep(5000);
            PdfDocument doc = new PdfDocument();
            PdfPageSettings setting = new PdfPageSettings();
            setting.Size = new System.Drawing.SizeF(1000, 1000);
            setting.Margins = new Spire.Pdf.Graphics.PdfMargins(20);
            PdfHtmlLayoutFormat htmlLayoutFormat = new PdfHtmlLayoutFormat();
            htmlLayoutFormat.IsWaiting = true;
            String url = "http://localhost:63324/Vistas/FrmExportarSolicitud.aspx";
            Thread thread = new Thread(() =>
            {
                doc.LoadFromHTML(url, false, false, false, setting, htmlLayoutFormat);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            //Save pdf file.         
            doc.SaveToFile("Solicitud.pdf");
            doc.Close();
            System.Diagnostics.Process.Start("Solicitud.pdf");         
        }

    }
}
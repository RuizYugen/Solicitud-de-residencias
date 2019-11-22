using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BackEnd.DAOS;
using BackEnd.Modelos;
using System.Threading;
using IronPdf;


namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmExportarSolicitud : System.Web.UI.Page
    {

       
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
        public static String usuario = "";

        //Si ya existe la versión de una solicitud
        static Boolean modificar = false;
        static DetallesSolicitud actualizar;
        static Alumno a;
        protected void Page_Load(object sender, EventArgs e)
        {

            periodo1.Items.Add("AGO-DIC");
            periodo1.Items.Add("ENE-JUN");
            if (!Page.IsPostBack)
            {
                llenarDatos();
                cargarSolicitud();
               
                //ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
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
                    String[] periodoArr = actualizar.periodo.Split(' ');
                    if (periodoArr[0].Equals("AGO-DIC"))
                    {
                        periodo1.SelectedIndex = 0;
                    }
                    else
                    {
                        periodo1.SelectedIndex = 1;
                    }
                    periodoAnio.Value = periodoArr[1];
                    // this.periodo.Value = actualizar.periodo;

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
            catch (Exception)
            {

            }


        }

        }

    }

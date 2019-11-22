using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BackEnd.DAOS;
using BackEnd.Modelos;
using IronPdf;

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
        static  String nombreResidente = "";
        String noControlR = "";
        String carreraStr = "";
        String domicilioStr = "";
        String emailStr = "";
        String ciudad = "";
        String seguro = "";
        String nSeguro = "";
        String telefonoStr = "";
        // Datos del alumno
      static String usuario = "";

        //Si ya existe la versión de una solicitud
        static Boolean modificar = false;
        static DetallesSolicitud actualizar;
        static Alumno a;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = Session["Usuario"].ToString();
            FrmExportarSolicitud.usuario = Session["Usuario"].ToString();
            periodo1.Items.Add("AGO-DIC");
            periodo1.Items.Add("ENE-JUN");
            if (!Page.IsPostBack)
            {
                this.rbBanco2.Checked = true;
                this.rbIndus.Checked = true;
                this.rbPublico.Checked = true;
                fechaCale2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                llenarDatos();
                cargarSolicitud();
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
                    }else
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
            catch(Exception)
            {

            }
           

        }
        public void guardarSolicitud()
        {
            DetallesSolicitud ds = new DetallesSolicitud();
            DetallesSolicitudDAO dao = new DetallesSolicitudDAO();
            if (!modificar)
            {
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

                ds.idSolicitud = lastId + 1;
                ds.noControl = a.noControl;
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


            }else
            {
               // actualizar.noControl = noControlR;
                actualizar.lugar = lugar;
                actualizar.fecha = DateTime.Parse(fechaStr);
                actualizar.coordinadorCarrera = coordinadorCarrera;
                actualizar.nombreProyecto = nombreProyectoS;
                actualizar.opcionElegida = opcionElegida;
                actualizar.periodo = periodoStr;
                actualizar.numeroResidentes = numeroResidentes;
                actualizar.nombreEmpresa = nombreEmpresaStr;
                actualizar.giro = giro;
                actualizar.sector = sector;
                actualizar.rfc = rfc;
                actualizar.domicilioEmpresa = domicilioEmpresa;
                actualizar.coloniaEmpresa = coloniaEmpresa;
                actualizar.cpEmpresa = cpEmpresa;
                actualizar.faxEmpresa = faxEmpresa;
                actualizar.ciudadEmpresa = ciudadEmpresa;
                actualizar.telefonoEmpresa = telefonoEmpresa;
                actualizar.misionEmpresa = misionEmpresa;
                actualizar.nombreTitularEmpresa = nombreTitularEmpresa;
                actualizar.puestoTitularEmpresa = puestoTitularEmpresa;
                actualizar.nombreAsesorExterno = nombreAsesorExterno;
                actualizar.puestoAsesorExterno = puestoAsesorExterno;
                actualizar.nombreAcuerdoTrabajo = nombreAcuerdoTrabajo;
                actualizar.puestoAcuerdoTrabajo = puestoAcuerdoTrabajo;
              //  actualizar.nombreResidente = nombreResidente;

                dao.update(actualizar);

            }

            // MsgBox(dao.getAll().Count + "", this.Page, this);

            //  ds.fecha = fechaStr;

            //  MsgBox(ds.fecha.Year.ToString(), this.Page, this);
            //  ds.giro = giro;
          

        }
        public Alumno obtenerAlumno()
        {
            Alumno al=new Alumno();
            AlumnoDAO dao= new AlumnoDAO();
            al = dao.getAlumnoByUsuario(usuario);
            return al;

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                lugar = "Uriangato Gto.";
                fechaStr = fechaCale2.Text.ToString();
                coordinadorCarrera = txtCoordinador.InnerText;//ObtenerCooordinadorCarrera
                nombreProyectoS = txtnombreProyecto.Value.ToString();
                bool banco = this.rbBanco2.Checked;
                bool propia = this.rbpropia2.Checked;
                bool trabajador = this.rbtrabajador2.Checked;
                if (banco)
                {
                    opcionElegida = rbBanco2.Value.ToString();
                }
                if (propia)
                {

                    opcionElegida = rbpropia2.Value.ToString();


                }
                if (trabajador)
                {
                    opcionElegida = rbtrabajador2.Value.ToString();
                }
                //  periodoStr = this.periodo.Value.ToString();
                periodoStr = periodo1.Text + " " + periodoAnio.Value.ToString();
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
                    giro = rbotroG.Value;
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
                actualizarAlumno();
                MsgBox("Solicitud Guardada con éxito.", this.Page, this);
                btnExportar.Visible = true;

            }
            catch (Exception ex){
                MsgBox("Verifique los datos ingresados.", this.Page, this);
            }

                    }
        public void actualizarAlumno()
        {
            a.domicilio = domicilioAlu.Value.ToString();
            a.email = email.Value.ToString();
            a.ciudad = ciudadAlu.Value.ToString();
            a.telefono = teleAlu.Value.ToString();
            a.numeroServicioSalud = noSeguro.Value.ToString();
            if (this.rbImss.Checked)
            {
                a.servicioSalud = this.rbImss.Value.ToString();
            }
            if (this.rbIssste.Checked)
            {
                a.servicioSalud = this.rbIssste.Value.ToString();
            }
            if (this.rbOtrosS.Checked)
            {
                a.servicioSalud = this.rbOtrosS.Value.ToString();
            }
            AlumnoDAO daoAl = new AlumnoDAO();
            daoAl.update(a);
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {

            Random rdn = new Random();
            int a = rdn.Next(1, 100000);
            String nombre = "Solicitud" + a + ".pdf";
            Response.Write("<script> window.open('" + "http://localhost:63324/Vistas/FrmExportarSolicitud.aspx" + "','_blank'); </script>");
            var Renderer = new IronPdf.HtmlToPdf();
            Renderer.PrintOptions.CreatePdfFormsFromHtml = false;
            Renderer.PrintOptions.MarginTop = 0;  //millimeters
            Renderer.PrintOptions.MarginBottom = 0;
            Renderer.PrintOptions.MarginLeft = 0;
            Renderer.PrintOptions.MarginRight = 0;
            var PDF = Renderer.RenderUrlAsPdf("http://localhost:63324/Vistas/FrmExportarSolicitud.aspx");
            PDF.SaveAs(nombre);
            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start(nombre);

        }
    }
}
using BackEnd.DAOS;
using BackEnd.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmDatosAlumno : System.Web.UI.Page
    {
        private bool flag = true;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Rol"] != null)
            {
                string cadena = Session["Rol"] + "";
                if (cadena.ToLower() == "alumno")
                {
                    
                    AlumnoDAO dao = new AlumnoDAO();
                    Alumno al = dao.getAlumnoByUsuario(Session["Usuario"].ToString());
                    if ( al!= null)
                    {
                        flag = false;
                        if (txtNoControl.Text=="")
                        {
                            txtCarrera.Items.Add("Ing. En Sistemas Computacionales");
                            txtCarrera.Items.Add("Ing. Electrónica");
                            txtCarrera.Items.Add("Ing. Informática");
                            txtCarrera.Items.Add("Ing. En Gestión Empresarial");
                            txtCarrera.Items.Add("Ing. Industrial");
                            txtCarrera.Items.Add("Ing. En Sistemas Automotrices");
                            txtCarrera.Items.Add("Ing. Ambiental");
                            txtServicioSalud.Items.Add("IMSS");
                            txtServicioSalud.Items.Add("ISSSTE");
                            txtServicioSalud.Items.Add("OTRO");
                            txtNoControl.Text = al.noControl;
                            txtNombre.Text = al.nombre;
                            txtApellidoPaterno.Text = al.apellidoPaterno;
                            txtApellidoMaterno.Text = al.apellidoMaterno;
                            txtCarrera.SelectedIndex = txtCarrera.Items.IndexOf(ListItem.FromString(al.carrera));
                            txtEmail.Text = al.email;
                            txtTelefono.Text = al.telefono;
                            txtDomicilio.Text = al.domicilio;
                            txtCiudad.Text = al.ciudad;
                            txtServicioSalud.SelectedIndex = txtServicioSalud.Items.IndexOf(ListItem.FromString( al.servicioSalud));
                            txtNoServicioSalud.Text = al.numeroServicioSalud;
                            txtAsesorInterno.Text = al.asesorInterno;
                            

                        }
                    }else
                    {
                        flag = true;
                        txtCarrera.Items.Add("Ing. En Sistemas Computacionales");
                        txtCarrera.Items.Add("Ing. Electrónica");
                        txtCarrera.Items.Add("Ing. Informática");
                        txtCarrera.Items.Add("Ing. En Gestión Empresarial");
                        txtCarrera.Items.Add("Ing. Industrial");
                        txtCarrera.Items.Add("Ing. En Sistemas Automotrices");
                        txtCarrera.Items.Add("Ing. Ambiental");
                        txtServicioSalud.Items.Add("IMSS");
                        txtServicioSalud.Items.Add("ISSSTE");
                        txtServicioSalud.Items.Add("OTRO");
                    }

                }
                else
                {
                  Response.Redirect("ControlDeAcceso.aspx");
                }
            }
            else
            {
               Response.Redirect("ControlDeAcceso.aspx");
            }
        }
      
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNoControl.Text.Length == 9 && txtTelefono.Text.Length == 10)
            {
                if (flag)
                {
                    Alumno alumno = new Alumno();
                    alumno.usuario = Session["Usuario"].ToString();
                    alumno.noControl = txtNoControl.Text;
                    alumno.nombre = txtNombre.Text;
                    alumno.apellidoPaterno = txtApellidoPaterno.Text;
                    alumno.apellidoMaterno = txtApellidoMaterno.Text;
                    alumno.carrera = txtCarrera.Text;
                    alumno.email = txtEmail.Text;
                    alumno.telefono = txtTelefono.Text;
                    alumno.domicilio = txtDomicilio.Text;
                    alumno.ciudad = txtCiudad.Text;
                    alumno.servicioSalud = txtServicioSalud.Text;
                    alumno.numeroServicioSalud = txtNoServicioSalud.Text;
                    alumno.asesorInterno = txtAsesorInterno.Text;
                    AlumnoDAO dao = new AlumnoDAO();
                    if (dao.insert(alumno))
                    {
                        Response.Write("<script>alert('Se guardo correctamente');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Se no se guardo correctamente');</script>");
                    }
                }
                else
                {
                    Alumno alumno = new Alumno();
                    alumno.usuario = Session["Usuario"].ToString();
                    alumno.noControl = txtNoControl.Text;
                    alumno.nombre = txtNombre.Text;
                    alumno.apellidoPaterno = txtApellidoPaterno.Text;
                    alumno.apellidoMaterno = txtApellidoMaterno.Text;
                    alumno.carrera = txtCarrera.Text;
                    alumno.email = txtEmail.Text;
                    alumno.telefono = txtTelefono.Text;
                    alumno.domicilio = txtDomicilio.Text;
                    alumno.ciudad = txtCiudad.Text;
                    alumno.servicioSalud = txtServicioSalud.Text;
                    alumno.numeroServicioSalud = txtNoServicioSalud.Text;
                    alumno.asesorInterno = txtAsesorInterno.Text;
                    AlumnoDAO dao = new AlumnoDAO();
                    if (dao.update(alumno))
                    {
                        Response.Write("<script>alert('Se guardo correctamente');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Se no se guardo correctamente');</script>");
                    }
                }
            }else
            {
                Response.Write("<script>alert('Ingrese correctamente los datos');</script>");
            }
            

        }

        protected void btnSolicitud_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmSolicitud.aspx");
        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmExportarSolicitud.aspx");
        }
    }
}
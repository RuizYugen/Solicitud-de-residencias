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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Rol"] != null)
            {
                string cadena = Session["Rol"] + "";
                if (cadena.ToLower() == "alumno")
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
    }
}
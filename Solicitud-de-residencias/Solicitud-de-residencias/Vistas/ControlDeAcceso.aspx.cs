using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BackEnd.Modelos;
using BackEnd.DAOS;
namespace Solicitud_de_residencias.Vistas
{
    public partial class ControlDeAcceso : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string user = Usuario_name.Text;
            string password = Contrasena_n.Text;
            Usuario acceso = ValidarUsuario(user, password);
            if (acceso != null)
            {
                Session["Usuario"] = acceso.usuario;
                Session["Rol"] = acceso.rol;

                switch (Session["Rol"].ToString())
                {
                    case "Alumno":
                        Response.Redirect("FrmSolicitud.aspx");
                        
                        break;
                    case "Administrador":
                        Response.Redirect("CatalogoUsuarios.aspx");
                        break;
                    case "Coordinador":
                        Response.Redirect("CatalogoUsuarios.aspx");
                        break;

                }

            }
            else
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(@"<script language='javascript'>");
                sb.Append(@"$('#contraseniaIncorrecta').modal('show');");
                sb.Append(@"</script>");

                ClientScript.RegisterStartupScript(this.GetType(), "JSScript", sb.ToString());
            }

        }

        protected Usuario ValidarUsuario(string id, string contrasenia)
        {
            UsuarioDAO user = new UsuarioDAO();
            Usuario u = user.esUsuario(id, contrasenia);
            if (u != null)
            {
                return u;
            }
            else
            {
                return null;

            }
        }
    }
}
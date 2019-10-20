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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Value;
            string contra = txtContrasena.Value;
            string rol = txtRol.Value;
            if (!usuario.Equals("")&&!contra.Equals("")&&!rol.Equals(""))
            {
                Usuario nuevo = new Usuario(usuario,contra,rol);
                UsuarioDAO dao = new UsuarioDAO();
                dao.insert(nuevo);
                Response.Redirect("CatalogoUsuarios.aspx");
            }
        }
    }
}
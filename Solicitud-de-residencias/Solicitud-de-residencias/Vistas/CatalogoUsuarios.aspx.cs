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
    public partial class CatalogoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new UsuarioDAO().getAll();
            string seleccionado = usuarios[GridView1.SelectedIndex].usuario + "";
            Session["usuario"] = seleccionado;
            Session["contrasena"] = usuarios[GridView1.SelectedIndex].contrasena;
            Session["rol"] = usuarios[GridView1.SelectedIndex].rol;
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                List<Usuario> usuarios = new UsuarioDAO().getAll();
                Usuario usuario = new Usuario(Session["usuario"].ToString(), Session["contrasena"].ToString(), Session["rol"].ToString());
               
                dao.delete(usuario);
                Response.Redirect("CatalogoUsuarios.aspx");
            }
            catch (NullReferenceException excep)
            {

                
            }            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarUsuario.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType==DataControlRowType.DataRow)
            {
                foreach (DataControlFieldCell cell in e.Row.Cells)
                {
                    foreach (Control control in cell.Controls)
                    {
                        LinkButton btn = control as LinkButton;
                        if (btn!=null&&btn.CommandName.Equals("Delete"))
                        {
                            btn.OnClientClick = "return confirm('¿Eliminar usuario?');";
                        }
                    }
                }
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmSolicitud.aspx");
        }
    }
}
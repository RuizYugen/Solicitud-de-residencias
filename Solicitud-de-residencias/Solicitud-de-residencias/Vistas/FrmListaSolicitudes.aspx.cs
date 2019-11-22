using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmListaSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Rol"] != null)
            {
                string cadena = Session["Rol"] + "";
                if (cadena.ToLower() == "coordinador")
                {

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
    }
}
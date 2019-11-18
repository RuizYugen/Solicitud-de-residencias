using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;

namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmExportarExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Rol"] != null) {
                string cadena = Session["Rol"] + "";
                if (cadena.ToLower() == "coordinador")
                {

                } else
                {
                    Response.Redirect("ControlDeAcceso.aspx");
                }
            } else
            {
                Response.Redirect("ControlDeAcceso.aspx");
            }
        }

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=ArchivoExportado.xls");
            Response.Charset = "";
            Response.ContentType = "application/es-excel";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            dgvSolicitudes.AllowPaging = false;
            dgvSolicitudes.DataBind();
            dgvSolicitudes.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
    }
}
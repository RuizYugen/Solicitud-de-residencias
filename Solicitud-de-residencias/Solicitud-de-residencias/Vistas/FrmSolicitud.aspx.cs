using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solicitud_de_residencias.Vistas
{
    public partial class FrmSolicitud : System.Web.UI.Page
    {

        int idSolicitud = 0;
        String noControl = "";
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
        String nombreResidente = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            lugar = "Uriangato Gto.";
            fechaStr = fechaCale2.Text.ToString();
            coordinadorCarrera = txtCoordinador.InnerText;
            nombreProyectoS = txtnombreProyecto.Value.ToString();
            bool banco = this.rbBanco.Checked;
            bool propia = this.rbpropia.Checked;
            bool trabajador = this.rbtrabajador.Checked;
            if (banco)
            {
                opcionElegida = rbBanco.Value.ToString();
            }
            if (propia)
            {

                opcionElegida = rbpropia.Value.ToString();


            }
            if (trabajador)
            {
                opcionElegida = rbtrabajador.Value.ToString();
            }
            periodoStr = this.periodo.Value.ToString();
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
                giro = rbtrabajador.Value;
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
                " " + rfc + " " + domicilioEmpresa + " " + coloniaEmpresa + " " + cpEmpresa + " " + faxEmpresa + " " + ciudadEmpresa + " "+
               telefonoEmpresa+" "+misionEmpresa+" "+nombreTitularEmpresa+" "+puestoTitularEmpresa+" "+
               nombreAsesorExterno+" "+puestoAsesorExterno+" "+nombreAcuerdoTrabajo+" "+puestoAcuerdoTrabajo;
            MsgBox(datos, this.Page, this);
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}
using BackEnd.Modelos;
using BackEnd.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAOS
{
    public class ExportarExcelDao
    {
        public List<ExportarExcel> getAll()
        {

            List<ExportarExcel> lista = new List<ExportarExcel>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select d.idSolicitud,'plan' as plan,'cons' as cons, a.noControl,concat(a.apellidoPaterno,' ',a.apellidomaterno,' ',a.nombre ) as nombre,'efren' as asesorInterno, d.nombreasesorexterno, d.nombreempresa, d.telefonoempresa, a.telefono from detallessolicitud d join alumno a on a.nocontrol = d.nocontrol; ");
            DataTable dt = datos.Tables[0];
            ExportarExcel e;
            foreach (DataRow r in dt.Rows)
            {

                e = new ExportarExcel();
                e.Id = (int)r.ItemArray[0];
                e.Plan = (string)r.ItemArray[1];
                e.Cons = (string)r.ItemArray[2];
                e.NoControl = (string)r.ItemArray[3];
                e.Nombre = (string)r.ItemArray[4];
                e.AsesorInterno = (string)r.ItemArray[5];
                e.Asesorexterno = (string)r.ItemArray[6];
                e.Empresa = (string)r.ItemArray[7];
                e.TelefonoEmpresa = (string)r.ItemArray[8];
                e.Telefono = (string)r.ItemArray[9];
                lista.Add(e);
            }
            return lista;
        }
    }
}

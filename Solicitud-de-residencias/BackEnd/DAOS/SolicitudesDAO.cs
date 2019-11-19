using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelos;
using BackEnd.Util;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace BackEnd.DAOS
{
    public class SolicitudesDAO
    {
        public List<Solicitudes> getAll()
        {

            List<Solicitudes> lista = new List<Solicitudes>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT detallessolicitud.idSolicitud,alumno.noControl, alumno.nombre, detallessolicitud.estado  FROM alumno INNER JOIN detallessolicitud where alumno.noControl = detallessolicitud.noControl" + ";");
            DataTable dt = datos.Tables[0];
            Solicitudes e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Solicitudes();
                e.idSolicitud = (int)r.ItemArray[0];
                e.noControl = (string)r.ItemArray[1];
                e.nombre = (string)r.ItemArray[2];
                e.estado = (Boolean)r.ItemArray[3];
                lista.Add(e);
            }
            return lista;
        }


        public bool actualizar(Solicitudes e)
        {
            Conexion conexion = new Conexion();

            String SQL;
            try
            {
                SQL = "UPDATE detallessolicitud SET estado = "+ e.estado+" WHERE idSolicitud like "+e.idSolicitud + ";";

                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}

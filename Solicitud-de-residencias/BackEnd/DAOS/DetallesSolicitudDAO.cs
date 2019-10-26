using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelos;
using BackEnd.Util;
using MySql.Data.MySqlClient;
using System.Data;
namespace BackEnd.DAOS
{
    public class DetallesSolicitudDAO
    {
        public List<DetallesSolicitud> getAll()
        {

            List<DetallesSolicitud> lista = new List<DetallesSolicitud>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM detallesSolicitud" + ";");
            DataTable dt = datos.Tables[0];
            DetallesSolicitud e;
            foreach (DataRow r in dt.Rows)
            {

                e = new DetallesSolicitud();
                e.idSolicitud = (int)r.ItemArray[0];
                e.noControl = (string)r.ItemArray[1];
                e.lugar = (string)r.ItemArray[2];
                e.fecha = (DateTime)r.ItemArray[3];
                e.coordinadorCarrera = (string)r.ItemArray[4];
                e.nombreProyecto = (string)r.ItemArray[5];
                e.opcionElegida = (string)r.ItemArray[6];
                e.periodo = (string)r.ItemArray[7];
                e.numeroResidentes = (int)r.ItemArray[8];
                e.nombreEmpresa = (string)r.ItemArray[9];
                e.giro = (string)r.ItemArray[10];
                e.sector = (string)r.ItemArray[11];
                e.rfc = (string)r.ItemArray[12];
                e.domicilioEmpresa = (string)r.ItemArray[13];
                e.coloniaEmpresa = (string)r.ItemArray[14];
                e.cpEmpresa = (string)r.ItemArray[15];
                e.faxEmpresa = (string)r.ItemArray[16];
                e.ciudadEmpresa = (string)r.ItemArray[17];
                e.telefonoEmpresa = (string)r.ItemArray[18];
                e.misionEmpresa = (string)r.ItemArray[19];
                e.nombreTitularEmpresa = (string)r.ItemArray[20];
                e.puestoTitularEmpresa = (string)r.ItemArray[21];
                e.nombreAsesorExterno = (string)r.ItemArray[22];
                e.puestoAsesorExterno = (string)r.ItemArray[23];
                e.nombreAcuerdoTrabajo = (string)r.ItemArray[24];
                e.puestoAcuerdoTrabajo = (string)r.ItemArray[25];
                e.nombreResidente = (string)r.ItemArray[26];
                lista.Add(e);
            }
            return lista;
        }

        public DetallesSolicitud getDetallesSolicitudById(int idSolicitud)
        {
            DetallesSolicitud e;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM detallesSolicitud WHERE idSolicitud = " + idSolicitud + ";");
            DataTable dt = datos.Tables[0];
            e = new DetallesSolicitud();
            DataRow r = dt.Rows[0];
            e.idSolicitud = (int)r.ItemArray[0];
            e.noControl = (string)r.ItemArray[1];
            e.lugar = (string)r.ItemArray[2];
            e.fecha = (DateTime)r.ItemArray[3];
            e.coordinadorCarrera = (string)r.ItemArray[4];
            e.nombreProyecto = (string)r.ItemArray[5];
            e.opcionElegida = (string)r.ItemArray[6];
            e.periodo = (string)r.ItemArray[7];
            e.numeroResidentes = (int)r.ItemArray[8];
            e.nombreEmpresa = (string)r.ItemArray[9];
            e.giro = (string)r.ItemArray[10];
            e.sector = (string)r.ItemArray[11];
            e.rfc = (string)r.ItemArray[12];
            e.domicilioEmpresa = (string)r.ItemArray[13];
            e.coloniaEmpresa = (string)r.ItemArray[14];
            e.cpEmpresa = (string)r.ItemArray[15];
            e.faxEmpresa = (string)r.ItemArray[16];
            e.ciudadEmpresa = (string)r.ItemArray[17];
            e.telefonoEmpresa = (string)r.ItemArray[18];
            e.misionEmpresa = (string)r.ItemArray[19];
            e.nombreTitularEmpresa = (string)r.ItemArray[20];
            e.puestoTitularEmpresa = (string)r.ItemArray[21];
            e.nombreAsesorExterno = (string)r.ItemArray[22];
            e.puestoAsesorExterno = (string)r.ItemArray[23];
            e.nombreAcuerdoTrabajo = (string)r.ItemArray[24];
            e.puestoAcuerdoTrabajo = (string)r.ItemArray[25];
            e.nombreResidente = (string)r.ItemArray[26];
            return e;
        }
        //Obtener por noControl
        public DetallesSolicitud getDetallesSolicitudByNoControl(string noControl)
        {
            DetallesSolicitud e;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM detallesSolicitud WHERE noControl like  '" + noControl + "';");
            DataTable dt = datos.Tables[0];
            e = new DetallesSolicitud();
            try
            {
                DataRow r = dt.Rows[0];
                e.idSolicitud = (int)r.ItemArray[0];
                e.noControl = (string)r.ItemArray[1];
                e.lugar = (string)r.ItemArray[2];
                e.fecha = (DateTime)r.ItemArray[3];
                e.coordinadorCarrera = (string)r.ItemArray[4];
                e.nombreProyecto = (string)r.ItemArray[5];
                e.opcionElegida = (string)r.ItemArray[6];
                e.periodo = (string)r.ItemArray[7];
                e.numeroResidentes = (int)r.ItemArray[8];
                e.nombreEmpresa = (string)r.ItemArray[9];
                e.giro = (string)r.ItemArray[10];
                e.sector = (string)r.ItemArray[11];
                e.rfc = (string)r.ItemArray[12];
                e.domicilioEmpresa = (string)r.ItemArray[13];
                e.coloniaEmpresa = (string)r.ItemArray[14];
                e.cpEmpresa = (string)r.ItemArray[15];
                e.faxEmpresa = (string)r.ItemArray[16];
                e.ciudadEmpresa = (string)r.ItemArray[17];
                e.telefonoEmpresa = (string)r.ItemArray[18];
                e.misionEmpresa = (string)r.ItemArray[19];
                e.nombreTitularEmpresa = (string)r.ItemArray[20];
                e.puestoTitularEmpresa = (string)r.ItemArray[21];
                e.nombreAsesorExterno = (string)r.ItemArray[22];
                e.puestoAsesorExterno = (string)r.ItemArray[23];
                e.nombreAcuerdoTrabajo = (string)r.ItemArray[24];
                e.puestoAcuerdoTrabajo = (string)r.ItemArray[25];
                e.nombreResidente = (string)r.ItemArray[26];
            }
            catch(Exception ex)
            {

            }
            
            return e;
        }
        public bool delete(int idSolicitud)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM detallesSolicitud WHERE" + " idSolicitud = " + idSolicitud + ";";
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

        public bool update(DetallesSolicitud e)
        {
            Conexion conexion = new Conexion();

            String SQL;
            try
            {
                String fechaFormato= e.fecha.ToString("yyyy-MM-dd");
                SQL = "UPDATE detallesSolicitud SET" +
               " idSolicitud=" + e.idSolicitud + ",noControl='" + e.noControl + "',lugar='" + e.lugar
               + "',fecha='" + fechaFormato +
               "',coordinadorCarrera='" + e.coordinadorCarrera + "',nombreProyecto='" + e.nombreProyecto +
               "',opcionElegida='" + e.opcionElegida + "',periodo='" + e.periodo + "'" +
               ",numeroResidentes=" + e.numeroResidentes + ",nombreEmpresa='" + e.nombreEmpresa + "'" +
               ",giro='" + e.giro + "'" + ",sector='" + e.sector + "'" + ",rfc='" + e.rfc + "'" +
               ",domicilioEmpresa='" + e.domicilioEmpresa + "'" + ",coloniaEmpresa='" + e.coloniaEmpresa + "'" +
               ",cpEmpresa='" + e.cpEmpresa + "'" + ",faxEmpresa='" + e.faxEmpresa + "'" + ",ciudadEmpresa='" + e.ciudadEmpresa + "'" +
               ",telefonoEmpresa='" + e.telefonoEmpresa + "'" + ",misionEmpresa='" + e.misionEmpresa + "'" +
               ",nombreTitularEmpresa='" + e.nombreTitularEmpresa + "'" + ",puestoTitularEmpresa='" + e.puestoTitularEmpresa + "'" +
               ",nombreAsesorExterno='" + e.nombreAsesorExterno + "'" + ",puestoAsesorExterno='" + e.puestoAsesorExterno + "'" +
               ",nombreAcuerdoTrabajo='" + e.nombreAcuerdoTrabajo + "'" + ",puestoAcuerdoTrabajo='" + e.puestoAcuerdoTrabajo + "'" +
               ",nombreResidente='" + e.nombreResidente + "'" +
               " WHERE idSolicitud = " + e.idSolicitud + ";";

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


        public bool insert(DetallesSolicitud i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO detallesSolicitud (idSolicitud,noControl,lugar,fecha,coordinadorCarrera,nombreProyecto,opcionElegida,periodo,numeroResidentes,nombreEmpresa,giro,sector,rfc,domicilioEmpresa,coloniaEmpresa,cpEmpresa,faxEmpresa,ciudadEmpresa,telefonoEmpresa,misionEmpresa,nombreTitularEmpresa,puestoTitularEmpresa,nombreAsesorExterno,puestoAsesorExterno,nombreAcuerdoTrabajo,puestoAcuerdoTrabajo,nombreResidente) " +
                    "VALUES (@idSolicitud,@noControl,@lugar,@fecha,@coordinadorCarrera,@nombreProyecto,@opcionElegida,@periodo,@numeroResidentes,@nombreEmpresa,@giro,@sector,@rfc,@domicilioEmpresa,@coloniaEmpresa,@cpEmpresa,@faxEmpresa,@ciudadEmpresa,@telefonoEmpresa,@misionEmpresa,@nombreTitularEmpresa,@puestoTitularEmpresa,@nombreAsesorExterno,@puestoAsesorExterno,@nombreAcuerdoTrabajo,@puestoAcuerdoTrabajo,@nombreResidente);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@idSolicitud", i.idSolicitud);
                sqlcom.Parameters.AddWithValue("@noControl", i.noControl);
                sqlcom.Parameters.AddWithValue("@lugar", i.lugar);
                sqlcom.Parameters.AddWithValue("@fecha", i.fecha);
                sqlcom.Parameters.AddWithValue("@coordinadorCarrera", i.coordinadorCarrera);
                sqlcom.Parameters.AddWithValue("@nombreProyecto", i.nombreProyecto);
                sqlcom.Parameters.AddWithValue("@opcionElegida", i.opcionElegida);
                sqlcom.Parameters.AddWithValue("@periodo", i.periodo);
                sqlcom.Parameters.AddWithValue("@numeroResidentes", i.numeroResidentes);
                sqlcom.Parameters.AddWithValue("@nombreEmpresa", i.nombreEmpresa);
                sqlcom.Parameters.AddWithValue("@giro", i.giro);
                sqlcom.Parameters.AddWithValue("@sector", i.sector);
                sqlcom.Parameters.AddWithValue("@rfc", i.rfc);
                sqlcom.Parameters.AddWithValue("@domicilioEmpresa", i.domicilioEmpresa);
                sqlcom.Parameters.AddWithValue("@coloniaEmpresa", i.coloniaEmpresa);
                sqlcom.Parameters.AddWithValue("@cpEmpresa", i.cpEmpresa);
                sqlcom.Parameters.AddWithValue("@faxEmpresa", i.faxEmpresa);
                sqlcom.Parameters.AddWithValue("@ciudadEmpresa", i.ciudadEmpresa);
                sqlcom.Parameters.AddWithValue("@telefonoEmpresa", i.telefonoEmpresa);
                sqlcom.Parameters.AddWithValue("@misionEmpresa", i.misionEmpresa);
                sqlcom.Parameters.AddWithValue("@nombreTitularEmpresa", i.nombreTitularEmpresa);
                sqlcom.Parameters.AddWithValue("@puestoTitularEmpresa", i.puestoTitularEmpresa);
                sqlcom.Parameters.AddWithValue("@nombreAsesorExterno", i.nombreAsesorExterno);
                sqlcom.Parameters.AddWithValue("@puestoAsesorExterno", i.puestoAsesorExterno);
                sqlcom.Parameters.AddWithValue("@nombreAcuerdoTrabajo", i.nombreAcuerdoTrabajo);
                sqlcom.Parameters.AddWithValue("@puestoAcuerdoTrabajo", i.puestoAcuerdoTrabajo);
                sqlcom.Parameters.AddWithValue("@nombreResidente", i.nombreResidente);
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

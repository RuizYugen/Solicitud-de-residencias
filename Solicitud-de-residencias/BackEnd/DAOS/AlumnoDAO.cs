using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Util;
using BackEnd.Modelos;
using MySql.Data.MySqlClient;
using System.Data;
namespace BackEnd.DAOS
{
    public class AlumnoDAO
    {
        public List<Alumno> getAll()
        {

            List<Alumno> lista = new List<Alumno>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM alumno" + ";");
            DataTable dt = datos.Tables[0];
            Alumno e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Alumno();
                e.noControl = (string)r.ItemArray[0];
                e.usuario = (string)r.ItemArray[1];
                e.nombre = (string)r.ItemArray[2];
                e.apellidoPaterno = (string)r.ItemArray[3];
                e.apellidoMaterno = (string)r.ItemArray[4];
                e.carrera = (string)r.ItemArray[5];
                e.email = (string)r.ItemArray[6];
                e.telefono = (string)r.ItemArray[7];
                e.domicilio = (string)r.ItemArray[8];
                e.ciudad = (string)r.ItemArray[9];
                e.servicioSalud = (string)r.ItemArray[10];
                e.numeroServicioSalud = (string)r.ItemArray[11];
                lista.Add(e);
            }
            return lista;
        }

        public Alumno getAlumnoByNoControl(string noControl)
        {
            Alumno e;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM alumno WHERE noControl like '" + noControl + "';");
            DataTable dt = datos.Tables[0];
            e = new Alumno();
            DataRow r = dt.Rows[0];
            e.noControl = (string)r.ItemArray[0];
            e.usuario = (string)r.ItemArray[1];
            e.nombre = (string)r.ItemArray[2];
            e.apellidoPaterno = (string)r.ItemArray[3];
            e.apellidoMaterno = (string)r.ItemArray[4];
            e.carrera = (string)r.ItemArray[5];
            e.email = (string)r.ItemArray[6];
            e.telefono = (string)r.ItemArray[7];
            e.domicilio = (string)r.ItemArray[8];
            e.ciudad = (string)r.ItemArray[9];
            e.servicioSalud = (string)r.ItemArray[10];
            e.numeroServicioSalud = (string)r.ItemArray[11];
            return e;
        }
        public Alumno getAlumnoByUsuario(string usuario)
        {
            Alumno e;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM alumno WHERE usuario like '" + usuario + "';");
            DataTable dt = datos.Tables[0];
            e = new Alumno();
            DataRow r = dt.Rows[0];
            e.noControl = (string)r.ItemArray[0];
            e.usuario = (string)r.ItemArray[1];
            e.nombre = (string)r.ItemArray[2];
            e.apellidoPaterno = (string)r.ItemArray[3];
            e.apellidoMaterno = (string)r.ItemArray[4];
            e.carrera = (string)r.ItemArray[5];
            e.email = (string)r.ItemArray[6];
            e.telefono = (string)r.ItemArray[7];
            e.domicilio = (string)r.ItemArray[8];
            e.ciudad = (string)r.ItemArray[9];
            e.servicioSalud = (string)r.ItemArray[10];
            e.numeroServicioSalud = (string)r.ItemArray[11];
            return e;
        }
        public bool delete(string noControl)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM alumno WHERE" + " noControl like '" + noControl + "';";
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


        public bool update(Alumno e)
        {
            Conexion conexion = new Conexion();

            String SQL;
            try
            {
                SQL = "UPDATE alumno SET" +
               " noControl='" + e.noControl + "',usuario='" + e.usuario + "',nombre='" + e.nombre
               + "',apellidoPaterno='" + e.apellidoPaterno +
               "',apellidoMaterno='" + e.apellidoMaterno + "',carrera='" + e.carrera + "',email='" + e.email + "',telefono='" + e.telefono + "'" + ",domicilio='" + e.domicilio + "'" + ",ciudad='" + e.ciudad + "'" + ",servicioSalud='" + e.servicioSalud + "'" + ",numeroServicioSalud='" + e.numeroServicioSalud + "'" +
               " WHERE noControl like '" + e.noControl + "';";

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

        public bool insert(Alumno i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO alumno (noControl,usuario,nombre,apellidoPaterno,apellidoMaterno,carrera,email,telefono,domicilio,ciudad,servicioSalud,numeroServicioSalud) VALUES (@noControl,@usuario,@nombre,@apellidoPaterno,@apellidoMaterno,@carrera,@email,@telefono,@domicilio,@ciudad,@servicioSalud,@numeroServicioSalud);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@noControl", i.noControl);
                sqlcom.Parameters.AddWithValue("@usuario", i.usuario);
                sqlcom.Parameters.AddWithValue("@nombre", i.nombre);
                sqlcom.Parameters.AddWithValue("@apellidoPaterno", i.apellidoPaterno);
                sqlcom.Parameters.AddWithValue("@apellidoMaterno", i.apellidoMaterno);
                sqlcom.Parameters.AddWithValue("@carrera", i.carrera);
                sqlcom.Parameters.AddWithValue("@email", i.email);
                sqlcom.Parameters.AddWithValue("@telefono", i.telefono);
                sqlcom.Parameters.AddWithValue("@domicilio", i.domicilio);
                sqlcom.Parameters.AddWithValue("@ciudad", i.ciudad);
                sqlcom.Parameters.AddWithValue("@servicioSalud", i.servicioSalud);
                sqlcom.Parameters.AddWithValue("@numeroServicioSalud", i.numeroServicioSalud);
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

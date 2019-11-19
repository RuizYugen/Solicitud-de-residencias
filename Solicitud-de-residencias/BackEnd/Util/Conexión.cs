using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BackEnd.Util
{
    public class Conexion
    {
        public static MySqlConnection conexion = null;

        public string GetConnectionString()
        {
            //Revisar: https://www.connectionstrings.com/mysql/

            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "root";
            String database = "solicitudResidencias";

            //Cadena de conexion

            return String.Format("server={0};port={1};user id={2}; password={3}; database={4}", servidor, puerto, usuario, password, database);
        }

        static public bool Conectar()
        {
            String parametrosConexion = "Server=127.0.0.1;Database=solicitudResidencias;Uid=root;Pwd=root;Port=3306;";


            conexion = new MySqlConnection(parametrosConexion);
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public DataTable ejecutarConsulta(MySqlCommand com)
        {
            try
            {
                if (Conectar())
                {
                    com.Connection = conexion;
                    MySqlDataAdapter objAdapter = new MySqlDataAdapter(com);
                    DataTable resultado = new DataTable();
                    objAdapter.Fill(resultado);
                    return resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

        }


        public int ejecutarSentencia(MySqlCommand objComando, bool esInsert)
        {
            int resultado = 0;
            try
            {
                if (Conectar())
                {
                    objComando.Connection = conexion;
                    MySqlDataAdapter objAdapter = new MySqlDataAdapter(objComando);
                    if (esInsert)
                    {
                        resultado = int.Parse(objComando.ExecuteScalar().ToString());
                    }
                    else
                    {
                        objComando.ExecuteNonQuery();
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        public void EjecutaSQLComando(MySqlCommand sqlCom)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            //MySqlCommand sqlCom = new MySqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                //sqlCom.CommandText = sComandoSql;
                sqlCom.ExecuteNonQuery();
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public DataSet LLenaComboGrid(string mysql)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            }
            finally
            {

                cnn.Close();
            }
            return ds;
        }

        public DataSet LLenaComboGrid(MySqlCommand cmd)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlConnection cnn = new MySqlConnection();
            try
            {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                //cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            }
            finally
            {

                cnn.Close();
            }
            return ds;
        }

    }
}

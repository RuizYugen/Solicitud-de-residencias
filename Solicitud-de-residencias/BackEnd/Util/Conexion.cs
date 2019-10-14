using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BackEnd.Util
{
    public class Conexion
    {
        public static MySqlConnection conexion = null;

        static public bool Conectar()
        {
            String parametrosConexion = "Server=127.0.0.1;Database=solicitudResidencias;Uid=root;Pwd=root;Port=3306;";

            // String parametrosConexion = "Server=mysql5014.site4now.net;Database=db_a4ac5e_ptmbd;Uid=a4ac5e_ptmbd;Pwd=anjoluande7.s;";
            conexion = new MySqlConnection(parametrosConexion);
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }



    }
}

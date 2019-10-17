using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelos;
using System.Data;
using MySql.Data.MySqlClient;
using BackEnd.Util;
using System.Security.Cryptography;
namespace BackEnd.DAOS
{
    public class UsuarioDAO
    {
        public List<Usuario> getAll()
        {

            List<Usuario> lista = new List<Usuario>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM usuario" + ";");
            DataTable dt = datos.Tables[0];
            Usuario e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Usuario();
                e.usuario = (string)r.ItemArray[0];
                e.contrasena = (string)r.ItemArray[1];
                e.rol = (string)r.ItemArray[2];
                lista.Add(e);
            }
            return lista;
        }




        public Usuario getUsuarioByUsuario(string usuario)
        {
            Usuario e;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM usuario WHERE usuario like '" + usuario + "';");
            DataTable dt = datos.Tables[0];
            e = new Usuario();
            DataRow r = dt.Rows[0];
            e.usuario = (string)r.ItemArray[0];
            e.contrasena = (string)r.ItemArray[1];
            e.rol = (string)r.ItemArray[2];
            return e;
        }

        public bool delete(string usuario)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM usuario WHERE" + " usuario like '" + usuario + "';";
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

        public bool update(Usuario e)
        {
            Conexion conexion = new Conexion();

            String SQL;
            try
            {
                SQL = "UPDATE usuario SET" + " usuario='" + e.usuario + "',contrasena='" + e.contrasena + "',rol='" + e.rol + " WHERE usuario like '" + e.usuario + "';";
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

        public bool insert(Usuario i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO usuario (usuario,contrasena,rol) VALUES (@usuario,@contrasena,@rol);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@usuario", i.usuario);
                sqlcom.Parameters.AddWithValue("@contrasena", i.contrasena);
                sqlcom.Parameters.AddWithValue("@rol", i.rol);
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Usuario esUsuario(string usuario, string contrasenia)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario where usuario = @user and contrasena = @password;");

                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@password", contrasenia);

                Usuario user = null;
                DataTable dt = con.ejecutarConsulta(cmd);

                if (dt != null)
                {

                    user = new Usuario((dt.Rows[0])[0].ToString(), (dt.Rows[0])[1].ToString(), (dt.Rows[0])[2].ToString());
                }

                return user;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }


        }


        public string getSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }

}

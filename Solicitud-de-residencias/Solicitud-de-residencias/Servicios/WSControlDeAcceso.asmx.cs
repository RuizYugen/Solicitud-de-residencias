using BackEnd.DAOS;
using BackEnd.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Solicitud_de_residencias.Servicios
{
    /// <summary>
    /// Descripción breve de WSControlDeAcceso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
     [System.Web.Script.Services.ScriptService]
    public class WSControlDeAcceso : System.Web.Services.WebService
    {

        [WebMethod]
        public Usuario validarUsuario(string usuario, string contrasenia)
        {
            UsuarioDAO user = new UsuarioDAO();
            Usuario us = user.esUsuario(usuario,contrasenia);
            if (us != null)
            {
                return us;

            }
            else { return null; }

        
           
        }
    }
}

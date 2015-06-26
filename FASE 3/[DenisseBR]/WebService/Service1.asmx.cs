using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace WebService
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        //------>RUTA DE CONEXION
        String cadenaConexion = "Data Source=DENISSEBR;Initial Catalog=Fase3V1;Integrated Security=True";
        SqlCommand miComandoSQL;
        SqlConnection miConexionBase = null;


        //------>LOG IN CLIENTE
        [WebMethod]
        public bool logC(String user, String pass)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Cliente  where UsuarioCliente='" + user + "' and PasswordC='" + pass + "'", cadenaConexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        //------>LOG IN EMPLEADO
        [WebMethod]
        public bool logE(String user, String pass)
        {
            String empleado = "empleado";
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and Contraseña='" + pass + "' and Rol='" + empleado + "'", cadenaConexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        //------>LOG IN DIRECTOR
        [WebMethod]
        public bool logD(String user, String pass)
        {
            String director = "director";
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and Contraseña='" + pass + "' and Rol='" + director + "'", cadenaConexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        //------>LOG IN PARA ADMIN 
        [WebMethod]
        public bool logA(String user, String pass)
        {
            String admin = "administrador";
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and Contraseña='" + pass + "' and Rol='" + admin + "'", cadenaConexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        [WebMethod]
        public String obtenerUs(String user, String tipo)
        {
            string nombre = "";
           if(tipo.Equals("cliente")){
               miComandoSQL = new SqlCommand("SELECT Nombre FROM Cliente WHERE UsuarioCliente = '" + user + "'");
               miConexionBase = new SqlConnection(cadenaConexion);
               miComandoSQL.Connection = miConexionBase;
               miConexionBase.Open();
               SqlDataReader lector = miComandoSQL.ExecuteReader();
               if (lector.HasRows)
               {
                   while (lector.Read())
                   {
                       nombre = lector.GetString(0);

                   }
               }
               lector.Close();
               miConexionBase.Close();
               return nombre;
           }
           else if (tipo.Equals("empleado"))
           {
               miComandoSQL = new SqlCommand("SELECT Nombre FROM Empleado WHERE UsuarioEmpleado = '" + user + "'");
               miConexionBase = new SqlConnection(cadenaConexion);
               miComandoSQL.Connection = miConexionBase;
               miConexionBase.Open();
               SqlDataReader lector = miComandoSQL.ExecuteReader();
               if (lector.HasRows)
               {
                   while (lector.Read())
                   {
                       nombre = lector.GetString(0);

                   }
               }
               lector.Close();
               miConexionBase.Close();
               return nombre;
           }
           else
           {
               return "Usuario Invalido";
           }
           
          
        }

        //--->CARGAR
        [WebMethod]
        public List<string> Categorias()
        {
            List<string> cat = new List<string>();
            SqlCommand comando = new SqlCommand("Select * FROM Categoria");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            string nombre = "";
            string valor = "";
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    nombre = lector.GetString(1);
                    valor = (lector.GetDouble(2).ToString());
                    cat.Add(nombre + " - " + valor + "%");
                }
            }
            return cat;
        }
    }
}
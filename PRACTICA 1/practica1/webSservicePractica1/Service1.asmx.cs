using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace webSservicePractica1
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


        String cadenaConexion = "Data Source=DENISSEBR;Initial Catalog=TareaPractica1;Integrated Security=True";
        SqlCommand miComandoSQL;
        SqlConnection miConexionBase = null;
        SqlDataAdapter adaptadorDatos;

        [WebMethod]
        public bool comprobar(ref string error)
        {
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                return true;
            }
            catch (SqlException e)
            {
                error = "No se pudo establecer la conexion" + e.Message.ToString();
                return false;
            }
            finally
            {
                if (miConexionBase != null)
                {
                    miConexionBase.Close();
                }
            }

        }

        [WebMethod]
        public bool AgregarLibro(String nombre, int existencia, int pagina, String autor, String tema, int disponibles, int prestamos, int reserva)
        {


            SqlCommand miComandoSQL = new SqlCommand("INSERT Libro (Nombrelibro, NumExistencias, NumPaginas, Autorlibro, Temalibro, disponibles, Prestamos, Reserva) values ('" + nombre + "','" + existencia + "','" + pagina + "','" + autor + "','" + tema + "','" + disponibles + "','" + prestamos + "','" + reserva + "')");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;

            miConexionBase.Open();
            if (miComandoSQL.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            miConexionBase.Close();
        }

        [WebMethod]
        public bool AgregarCliente(int carnet, String nombre, long dpi, String direccion, long telefono)
        {

            SqlCommand miComandoSQL = new SqlCommand("insert into cliente values ('" + carnet + "','" + nombre + "','" + dpi + "','" + direccion + "','" + telefono + "')");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            if (miComandoSQL.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            miConexionBase.Close();
        }

        [WebMethod]
        public bool buscarLibro(String nombre)
        {

            SqlCommand miComandoSQL = new SqlCommand("select * from libro where nombreLibro = " + nombre);
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            if (miComandoSQL.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            miConexionBase.Close();
        }
    }
}
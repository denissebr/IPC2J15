using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webServiceTareaPractica1
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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        String cadenaConexion = "Data Source=(local);Initial Catalog=ipc2;Integrated Security=True";
        SqlCommand miComandoSQL;
        SqlConnection miConexionBase;
        SqlDataAdapter adaptadorDatos;

        public void inicia()
        {
            miConexionBase = new SqlConnection();
            miConexionBase.ConnectionString = cadenaConexion;
            miConexionBase.Open();
        }

        public void AgregarLibro(String nombre, int existencia,int pagina,String tema,String autor)
        {
            inicia();
            SqlCommand miComandoSQL = new SqlCommand("insert into libro values ('" + nombre + "','" + existencia + "','"+ pagina+"','" +tema+"','" +autor +"')", miConexionBase);
            miComandoSQL.ExecuteNonQuery();
            miConexionBase.Close();
        }

        public void AgregarCliente(String nombre, int existencia, int pagina, String tema, String autor)
        {
            inicia();
            SqlCommand miComandoSQL = new SqlCommand("insert into libro values ('" + nombre + "','" + existencia + "','" + pagina + "','" + tema + "','" + autor + "')", miConexionBase);
            miComandoSQL.ExecuteNonQuery();
            miConexionBase.Close();
        }

    }
}
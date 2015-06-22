using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    [WebService(Namespace = "http://quetzalexpress.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class Service1 : System.Web.Services.WebService
    {
        String cadenaConexion = "Data Source=DENISSEBR;Initial Catalog=IPC2J15;Integrated Security=True";
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
        public string[] devuelveCategoria()
        {
            String [] lista=null;
            return lista;
        }

        [WebMethod]
        public String cotizar(float precio,float peso)
        {
            float precioq = precio*Convert.ToSingle(7.74);
            float libras = peso*5;
            float comision = Convert.ToSingle(0.05);
            float parcial = (precioq + libras) * comision;
            float total = parcial + precioq + libras;
            
            return Convert.ToString(total);
            
        }

        [WebMethod]
        public void cargarEmpleado(String direccion)
        {
             
            
             SqlCommand miComandoSQL = new SqlCommand("BULK INSERT Empleado FROM '" + direccion + "' WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',', ROWTERMINATOR = '\n', TABLOCK )");
             miConexionBase = new SqlConnection(cadenaConexion);
             miComandoSQL.Connection = miConexionBase;
             miConexionBase.Open();
             miComandoSQL.ExecuteNonQuery();
             miConexionBase.Close();        
                  
                   
          
        }
        [WebMethod]
        public void cargarCategoria(String direccion)
        {
             SqlCommand miComandoSQL = new SqlCommand("BULK INSERT Categoria FROM '" + direccion + "' WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',', ROWTERMINATOR = '\n', TABLOCK )");
             miConexionBase = new SqlConnection(cadenaConexion);
             miComandoSQL.Connection = miConexionBase;
             miConexionBase.Open();
             miComandoSQL.ExecuteNonQuery();
             miConexionBase.Close(); 
               
            
        }
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
                    cat.Add(nombre + "-" + valor);
                }
            }
            return cat;
        }


       
    }
}
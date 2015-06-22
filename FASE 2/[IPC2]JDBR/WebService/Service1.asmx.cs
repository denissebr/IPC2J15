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

       
    }
}
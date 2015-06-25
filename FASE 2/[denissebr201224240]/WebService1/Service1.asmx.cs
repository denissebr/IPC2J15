using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace WebService1
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
        String cadenaConexion = "Data Source=DENISSEBR;Initial Catalog=IPC2J15;Integrated Security=True";
        SqlCommand miComandoSQL;
        SqlConnection miConexionBase = null;


        //------>LOG IN CLIENTE
        [WebMethod]
        public bool logC(String user, String pass)
        {
            int estado = 1;
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Cliente  where Usuario='" + user + "' and Contraseña='" + pass + "'and Activo='"+estado+"'", cadenaConexion);
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
        public int logE(String user, String pass)
        {
            String empleado = "empleado";
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and Contraseña='" + pass + "' and Rol='" + empleado + "'", cadenaConexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                return 1;

            }
            else
            {
                return 0;
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
        
        //------>DEPEDIR EMPLEADO
        [WebMethod]
        public void despedir(String id)
        {
            SqlCommand miComandoSQL = new SqlCommand("delete from Empleado where codigo='" + id + "'and Rol='" + "empleado" + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            miComandoSQL.ExecuteNonQuery();
            miConexionBase.Close();
        }
        //------>CARGA DE ARCHIVOS CSV 
        //------>direccion es el path del archivo que se jala del fileupload
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

        //---->REGISTRAR USUARIO
        [WebMethod]
       
        public List<string> sucursal()
        {
            List<string> cat = new List<string>();
            SqlCommand comando = new SqlCommand("Select * FROM Sucursal");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            string direccion = "";
            
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    direccion = lector.GetString(2);
                    
                    cat.Add(direccion);
                }
            }
            return cat;
        }
        [WebMethod]
        public void registrar(int dpi,string nombre,string apellido,int nit,int telefono,string direccion,long tarjeta,int sucursal,string usuario,string contra,int estado)
        {
            SqlCommand miComandoSQL = new SqlCommand("INSERT INTO CLIENTE (DPI,Nombre,Apellidos,NIT,Telefono,Domicilio,Tarjeta,IdSucursal,Usuario,Contraseña,Estado), VALUES('" + dpi + "','" + nombre + "','" + apellido + "','" + nit + "','" + telefono + "','" + direccion + "','" + tarjeta + "','" + sucursal + "','" + usuario + "','" + contra + "','"+0+"'");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            miComandoSQL.ExecuteNonQuery();
            miConexionBase.Close();
        }
        //---->COTIZAR
        [WebMethod]
        public String cotizar(float precio, float peso)
        {
            float precioq = precio * Convert.ToSingle(7.74);
            float libras = peso * 5;
            float comision = Convert.ToSingle(0.05);
            float parcial = (precioq + libras) * comision;
            float total = parcial + precioq + libras;

            return Convert.ToString(total);

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
                    cat.Add(nombre + " - " + valor + "%");
                }
            }
            return cat;
        }

        //----> DATOS USUARIO
        [WebMethod]
        public string DevolverNombreCliente(String usuario)
        {
            string nombre = "";
            string apellido = "";
            SqlCommand comando = new SqlCommand("SELECT Nombre FROM Cliente WHERE Usuario = '" + usuario+"'");
            SqlCommand comando1 = new SqlCommand();
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
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



    }
}
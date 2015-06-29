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

        //-->Obtener Sucursales
        [WebMethod]
        public List<string> Sucursal()
        {
            List<string> sucursal = new List<string>();
            SqlCommand comando = new SqlCommand("Select Direccion FROM Sucursal");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            string nombre = "";
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    nombre = lector.GetString(0);
                    sucursal.Add(nombre);
                }
            }
            return sucursal;
        }
    
        //-->Obtener Sucursales
        [WebMethod]
        public int ObtenerSucursal(String direccion)
        {
            List<string> sucursal = new List<string>();
            SqlCommand comando = new SqlCommand("Select IdSucursal FROM Sucursal where Direccion='"+direccion+"'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            int  numero = 0;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    numero = lector.GetInt32(0);
                    
                }
            }
            return numero;
        }

        [WebMethod]
        public int sucursalPedido(String usuario)
        {
            SqlCommand comando = new SqlCommand("Select IdSucursal FROM Cliente where UsuarioCliente='" + usuario + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            int idsucur = 0;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    idsucur = lector.GetInt32(0);

                }
            }
            return idsucur;
        }

        [WebMethod]
        public String direccionSucur(int id)
        {
            SqlCommand comando = new SqlCommand("Select * FROM Sucursal where IdSucursal='" + id + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            String nombre = "";
            String direc = "";
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    nombre = lector.GetString(1);
                    direc = lector.GetString(2);

                }
            }
            return nombre+" "+direc;
        }


        //-->Ingresar Cliente
        [WebMethod]
        public bool verificarUs(String user)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Cliente  where UsuarioCliente='" + user+"'", cadenaConexion);
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
        //--->AGREGAR USUARIO
        [WebMethod]

        public bool registrarUS(String nombre, String apellido, long dpi, int telefono, int nit,String direccion, int estado, String usuario, String passw, int IdSucursal)
        {
            SqlCommand comando = new SqlCommand("Insert into Cliente (Nombre, Apellido,Dpi,Telefono,Nit,Direccion,Estado,UsuarioCliente,PasswordC,IdSucursal) values ('" + nombre + "','" + apellido + "','" + dpi + "','" + telefono + "','" + nit + "','" + direccion + "','" + estado + "','" + usuario + "','" + passw + "','" + IdSucursal + "')");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            comando.ExecuteNonQuery();
            miConexionBase.Close();
            
            return true;
        }

        //--->REGISTRAR PEDIDO
        [WebMethod]
        public void registrarPedido(float peso,float precio,String estado,long dpi,int idcategoria)
        {

        }

        //--->OBTENER DPI CLIENTE

        [WebMethod]
        public long obtenerDPI(String user)
        {
            long dpi=0;
            miComandoSQL = new SqlCommand("SELECT Dpi FROM Cliente WHERE UsuarioCliente = '" + user + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    dpi = lector.GetInt64(0);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return dpi;
        }


        //--->OBTENER DATOS USUARIO
        [WebMethod]
        public DataSet obtenerDatosUs(long dpi)
        {
            DataSet ds = new DataSet();
            miConexionBase  = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select nombre,apellido,dpi,telefono,nit,direccion,UsuarioCliente,PasswordC from Cliente where dpi="+dpi, miConexionBase);
                SqlDataAdapter da =new SqlDataAdapter(miComandoSQL);
                da.Fill(ds);
            }
            catch
            {
                ds = null;
            }
            finally
            {
                miConexionBase.Close();
            }
           
                return ds;
            
        }
        //--->ACTUALIZAR DATOS CLIENTE
        [WebMethod]
        public int ActualizarDatos(String nom, String apellido, long dpi, int telefono, int nit, String direccion, String usuario, String passw, int IdSucursal)
        {
            SqlCommand comando = new SqlCommand("Update  Cliente set Nombre='" + nom + "', Apellido='" + apellido + "', Telefono='" + telefono + "', Nit='" + nit + "', Direccion='" + direccion + "', PasswordC='" + passw + "', IdSucursal='" + IdSucursal + "' where Dpi='" + dpi+"'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            miConexionBase.Close();

        }

        //--->OBTENER DATOS USUARIO
        [WebMethod]
        public DataSet obtenerDatosPed(long dpi)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select Nombre,Descripcion,Estado from Paquete where dpi=" + dpi, miConexionBase);
                SqlDataAdapter da = new SqlDataAdapter(miComandoSQL);
                da.Fill(ds);
            }
            catch
            {
                ds = null;
            }
            finally
            {
                miConexionBase.Close();
            }

            return ds;

        }


        //--------------------------------------MODULO DE EMPLEADO-----------------------------------------------------------------
        //----------------------------------------SERVICIO AL CLIENTE--------------------------------------------------------------

        //--->OBTENER CASILLA USUARIO
        [WebMethod]
        public DataSet obtenerCasilla(String Texto)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select nombre,apellido,dpi,telefono,nit,direccion,Casilla,Estado,UsuarioCliente from Cliente where Nombre='" + Texto+"'", miConexionBase);
                SqlDataAdapter da = new SqlDataAdapter(miComandoSQL);
                da.Fill(ds);
            }
            catch
            {
                ds = null;
            }
            finally
            {
                miConexionBase.Close();
            }

            return ds;

        }

        //--->CLIENTES PENDIENTES DE APROVACION
        [WebMethod]
        public DataSet clientePendienteApr()
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select Nombre,Apellido,Dpi,Telefono,Nit,Direccion,Casilla,Estado,UsuarioCliente from Cliente where Estado="+0 , miConexionBase);
                SqlDataAdapter da = new SqlDataAdapter(miComandoSQL);
                da.Fill(ds);
            }
            catch
            {
                ds = null;
            }
            finally
            {
                miConexionBase.Close();
            }

            return ds;

        }
        //-->ACTUALIZAR ESTADO CLIENTE
        [WebMethod]
        public int ActualizarEstado(long dpi)
        {
            SqlCommand comando = new SqlCommand("Update  Cliente set  Estado= 1  where Dpi='" + dpi + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            miConexionBase.Close();

        }
       
    }
}
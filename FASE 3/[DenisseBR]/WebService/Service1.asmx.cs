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

        //------------------------------------------------------------------------------------------------------
        //******************************************LOG IN******************************************************
        //------>LOG IN CLIENTE
        [WebMethod]
        public bool logC(String user, String pass)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Cliente  where UsuarioCliente='" + user + "' and PasswordC='" + pass + "' and Estado=1", cadenaConexion);
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
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and PasswordE='" + pass + "' and Tipo='" + empleado + "' and Habilitado=1", cadenaConexion);
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
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and PasswordE='" + pass + "' and Tipo='" + director + "'", cadenaConexion);
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
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Empleado  where UsuarioEmpleado='" + user + "' and PasswordE='" + pass + "' and Tipo='" + admin + "'", cadenaConexion);
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
        //------------------------------------------------------------------------------------------------------
        //******************************************OBTENER DATOS***********************************************
        //--->OBTENER EL NOMBRE DEL USUARIO
        [WebMethod]
        public String obtenerUs(String user)
        {
            string nombre = "";
            string apellido = "";
               miComandoSQL = new SqlCommand("SELECT * FROM Cliente WHERE UsuarioCliente = '" + user + "'");
               miConexionBase = new SqlConnection(cadenaConexion);
               miComandoSQL.Connection = miConexionBase;
               miConexionBase.Open();
               SqlDataReader lector = miComandoSQL.ExecuteReader();
               if (lector.HasRows)
               {
                   while (lector.Read())
                   {
                       nombre = lector.GetString(0);
                       apellido = lector.GetString(1);

                   }
               }
               lector.Close();
               miConexionBase.Close();
               return nombre+" "+apellido;      
        }
        //--->OBTENER EL NOMBRE DEL EMPLEADO
        [WebMethod]
        public String obtenerEmp(String user)
        {
            string nombre = "";
            string apellido = "";
            int id = 0;
            miComandoSQL = new SqlCommand("SELECT * FROM Empleado WHERE UsuarioEmpleado = '" + user + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = lector.GetInt32(0);
                    nombre = lector.GetString(1);
                    apellido = lector.GetString(2);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return "Codigo: "+id+" Nombre: "+nombre+" "+apellido;
        }
     
        //--->OBTENER TIPO DE EMPLEADO
        [WebMethod]
        public int tipoEmp(String user)
        {
            int tipo=0;
            miComandoSQL = new SqlCommand("SELECT Rol FROM Empleado WHERE UsuarioEmpleado = '" + user + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    tipo = lector.GetInt32(0);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return tipo;
        }

     
        //--->OBTENER DPI CLIENTE

        [WebMethod]
        public long obtenerDPI(String user)
        {
            long dpi = 0;
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
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select nombre,apellido,dpi,telefono,nit,direccion,UsuarioCliente,PasswordC, NoTarjeta from Cliente where dpi=" + dpi, miConexionBase);
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
        [WebMethod]
        public DataSet perfilIndividual(int IdEmp)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("select 'Identificador'=E.IdEmpleado, E.Nombre,E.Apellido,E.Telefono,E.Sueldo,E.Direccion,'Rol'=D.Nombre,'Usuario'=E.UsuarioEmpleado,'Contraseña'=E.PasswordE,S.Nombre,H.FechaInicio,H.Fechafin from Empleado E join historialEmp H on  H.IdEmpleado = E.IdEmpleado join Departamento D on D.IdDepartamento=E.Rol join Sucursal S on S.IdSucursal=E.IdSucursal where E.IdEmpleado="+IdEmp, miConexionBase);
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
        //--->MOSTRAR DATOS DEL PEDIDO
        [WebMethod]
        public DataSet mostrarDatosPed(long dpi)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("SELECT C.casilla, 'Identificador de Paquete'=P.IdPaquete, P.Nombre, P.Descripcion FROM dbo.Paquete P JOIN dbo.Cliente C ON P.Dpi = C.Dpi where IdEstado=1 and P.Dpi=" + dpi, miConexionBase);
                SqlDataAdapter da = new SqlDataAdapter(miComandoSQL);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                miConexionBase.Close();
            }

            return ds;

        }
        //--->MOSTRAR DATOS PEDIDO INDIVIDUAL
        [WebMethod]
        public DataSet mostrarDatosPedIn(int IdPa)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("select Categoria=C.Nombre, P.Precio, P.Peso,'Fecha de Modificacion'= E.FechaMod, Estado=EP.EstadoDes from dbo.Paquete p join dbo.Categoria C on P.IdCategoria = C.IdCategoria join dbo.historialPa E on P.IdPaquete=E.IdPaquete  join dbo.EstadoPaqete EP on E.EstadoTrack=EP.EstadoTrack where P.IdPaquete="+IdPa, miConexionBase);
                SqlDataAdapter da = new SqlDataAdapter(miComandoSQL);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
               throw ex;
              
            }
            finally
            {
                miConexionBase.Close();
            }

            return ds;

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
        //------------------------------------------------------------------------------------------------------------
        //*******************************************CARGAR DATOS*****************************************************
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
        public int ObtenerSucursalEmpl(String user)
        {
            SqlCommand comando = new SqlCommand("Select IdSucursal FROM Empleado where UsuarioEmpleado='" + user + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            int numero = 0;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    numero = lector.GetInt32(0);

                }
            }
            return numero;
        }
        //-->Obtener categoria
        [WebMethod]
        public int Obtenericcat(String nombre)
        {
            SqlCommand comando = new SqlCommand("Select IdCategoria FROM Categoria where Nombre='" + nombre + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            int numero=0;
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
        //--->OBTENER DEPARTAMENTO
        [WebMethod]
        public int obtenerDept(String usuario)
        {
            SqlCommand comando = new SqlCommand("Select Rol FROM Empleado where UsuarioEmpleado='" + usuario + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            int rol = 0;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    rol = lector.GetInt32(0);

                }
            }
            return rol;
        }
        //--->nombreDept
        [WebMethod]
        public string nombredept(int rol)
        {
            SqlCommand comando = new SqlCommand("Select Nombre FROM Departamento where IdDepartamento='" + rol + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            String dept=""; 
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    dept = lector.GetString(0);

                }
            }
            return dept;
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


       
       

        //--->REGISTRAR PEDIDO
      
        [WebMethod]
        public DataSet mostrarPedido()
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {

                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select Nombre,Apellido,Dpi,Telefono,Nit,Direccion,Casilla,Estado,UsuarioCliente from Cliente where Estado=" + 0, miConexionBase);
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
                miComandoSQL = new SqlCommand("SELECT Nombre,Apellido,Dpi,Telefono,Nit,Direccion,Casilla,Estado,UsuarioCliente FROM cliente WHERE CONCAT (Nombre,Apellido,Dpi,Telefono,Nit,Direccion,Casilla,UsuarioCliente) LIKE '%"+Texto+"%'", miConexionBase);
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
//----
        [WebMethod]
        public long devolverDPI(int cas)
        {
            long dpi=0;
            miComandoSQL = new SqlCommand("select dpi from cliente where casilla="+cas, miConexionBase);
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
        [WebMethod]
        public DataSet tablaDevolver(long dpi)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {

                miConexionBase.Open();
                miComandoSQL = new SqlCommand("select C.Casilla,P.IdPaquete,C.Nombre,C.Apellido,P.Nombre,P.Descripcion,'Precio Q'=P.Precio,'Peso LB'=P.Peso, Estado=E.EstadoDes from Paquete P join Cliente C on C.Dpi=P.Dpi  join historialPa H on H.IdPaquete=P.IdPaquete join EstadoPaqete E on E.EstadoTrack=H.EstadoTrack where C.Dpi='" + dpi + "'and H.EstadoTrack=6", miConexionBase);
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
        [WebMethod]
        public int Rechazar(long dpi)
        {
            SqlCommand comando = new SqlCommand("Delete  Cliente where Dpi='" + dpi + "'");
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
        //---------------------------------------------------------------------------------------------------------
        //--------------------------------------------BODEGA-------------------------------------------------------
        [WebMethod]
        public bool actualizarPrecio(int idpa,float precio,int estado)
        {
            SqlCommand comando = new SqlCommand("Update  Paquete set Precio='"+precio+"', IdEstado= 3 where IdPaquete=" + idpa);
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            miConexionBase.Close();
        }
        
        //---------------------------------------------------------------------------------------------------------
        //********************************************CLIENTE******************************************************
        //------------------------------------------OBTENER COMISION-----------------------------------------------
        //--->ACTUALIZAR DATOS CLIENTE
        [WebMethod]
        public int ActualizarDatos(String nom, String apellido, long dpi, int telefono, int nit, String direccion, String usuario, String passw, int IdSucursal, long tarjeta)
        {
            SqlCommand comando = new SqlCommand("Update  Cliente set Nombre='" + nom + "', Apellido='" + apellido + "', Telefono='" + telefono + "', Nit='" + nit + "', Direccion='" + direccion + "', PasswordC='" + passw + "', IdSucursal='" + IdSucursal + "', NoTarjeta='" + tarjeta + "' where Dpi='" + dpi + "'");
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
        //--->COTIZAR
        [WebMethod]
        public String cotizar(float precio, float peso,float tipo)
        {
            float precioq = precio * Convert.ToSingle(7.74);
            float libras = peso * 5;
            float comision = Convert.ToSingle(0.05);
            float parcial = (precioq + libras) * comision;
            float total = parcial + precioq + libras;
            float temporal = (tipo * precio) / 100;
            float totalf = Convert.ToSingle(total) + temporal;
            return "Q" + totalf.ToString();

        }
        //-->Ingresar Cliente
        [WebMethod]
        public bool verificarUs(String user)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) FROM Cliente  where UsuarioCliente='" + user + "'", cadenaConexion);
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

        public bool registrarUS(String nombre, String apellido, long dpi, int telefono, int nit, String direccion, int estado, String usuario, String passw, int IdSucursal, long tarjeta)
        {
            SqlCommand comando = new SqlCommand("Insert into Cliente (Nombre, Apellido,Dpi,Telefono,Nit,Direccion,Estado,UsuarioCliente,PasswordC,IdSucursal,NoTarjeta) values ('" + nombre + "','" + apellido + "','" + dpi + "','" + telefono + "','" + nit + "','" + direccion + "','" + estado + "','" + usuario + "','" + passw + "','" + IdSucursal + "','" + tarjeta + "')");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //--->CREAR PEDIDO
        //---> CREAR PEDIDO PRECIO
        [WebMethod]
        public bool PedidoPrecio(string nombre, string descripcion, float peso, float precio, long dpi, int idcat, int idest, float valor, int idsuc)
        {
           
            float precioq = precio * Convert.ToSingle(7.74);
            float libras = peso * 5;
            float comision = Convert.ToSingle(0.05);
            float parcial = (precioq + libras) * comision;
            float total = parcial + precioq + libras;
            float temporal = (valor * precio) / 100;
            float precioAc = total + temporal;
            SqlCommand comando = new SqlCommand("Insert into Paquete (Nombre, Descripcion,peso,precio,dpi,idCategoria,idEstado, idsucursal) values ('" + nombre + "','" + descripcion + "','" + peso + "','" + precioAc + "','" + dpi + "','" + idcat + "','" + idest + "','" + idsuc + "')");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //---> CREAR PEDIDO PRECARGA
        [WebMethod]
        public bool PedidoPrecioF(string nombre, string descripcion, float peso, string precio, long dpi, int idcat, int idest,int idsuc)
        {
            SqlCommand comando = new SqlCommand("Insert into Paquete (Nombre, Descripcion,peso,precioF,dpi,idCategoria,idEstado, idsucursal) values ('" + nombre + "','" + descripcion + "','" + peso + "','" + precio + "','" + dpi + "','" + idcat + "','" + idest + "','" + idsuc + "')");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       /* //--->VER PEDIDOS GENERALES
        [WebMethod]
        public DataSet mostrarPedidosG(String usuario)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {

                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select IdEmpleado,Nombre,Apellido,Sueldo from Empleado where Rol='" + departamento + "' and Tipo='" + tipo + "'", miConexionBase);
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
        }*/
        //---------------------------------------------------------------------------------------------------------
        //********************************************DIRECTOR*****************************************************
        //------------------------------------------MOSTRAR EMPLEADOS DEL DEPARTAMENTO-----------------------------
        //--->DESPEDIR EMPLEADO
        [WebMethod]
        public int despedir(int codigoEmp)
        {
            SqlCommand comando = new SqlCommand("Update  Empleado set Habilitado=0 where IdEmpleado="+codigoEmp);
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

        [WebMethod]
        public DataSet mostrarEmpleado(int sucursal, int departamento)
        {
            DataSet ds = new DataSet();
            string tipo = "empleado";
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {

                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select IdEmpleado,Nombre,Apellido,Sueldo from Empleado where Rol='" +departamento+"' and Tipo='"+tipo+"'" , miConexionBase);
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
        [WebMethod]
        public DataSet mostrarEquipo(int sucursal, int departamento)
        {
            DataSet ds = new DataSet();
            string tipo = "empleado";
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {

                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select IdEmpleado,Nombre,Apellido,Sueldo from Empleado where Rol='" + departamento + "' and Tipo='" + tipo + "' and Habilitado=1", miConexionBase);
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
        //--->EMPLEADO
        [WebMethod]
        public DataSet obtenerDatosEmp(int cod)
        {
            DataSet ds = new DataSet();
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select * from Empleado where IdEmpleado=" + cod, miConexionBase);
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
        //--->DEPARTAMENTOS
        [WebMethod]
        public List<string> departamentos()
        {
            List<string> departamento = new List<string>();
            SqlCommand comando = new SqlCommand("Select Nombre FROM Departamento");
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
                    departamento.Add(nombre);
                }
            }
            return departamento;
        }
        //--->ACTUALIZAR DATOS EMPLEADO
        [WebMethod]
        public int ActualizarDatosEmp(String nom, String apellido, int telefono, float sueldo, String direccion,int rol, String usuario, String passw,int cod)
        {
            SqlCommand comando = new SqlCommand("Update  Empleado set Nombre='" + nom + "', Apellido='" + apellido + "', Telefono='" + telefono + "', sueldo='" + sueldo + "', Direccion='" + direccion + "', rol='" + rol + "', usuarioEmpleado='" + usuario + "', PasswordE='" + passw + "' where IdEmpleado=" + cod);
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
        //--->MOSTRAR PAQUETES APROBADOS POR EMPLEADO
        [WebMethod]
        public DataSet mostrarPrecarga()
        {
            DataSet ds = new DataSet();
            int estado = 2;
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select IdPaqute, Nombre, PrecioF from Paquete where IdEstado='"+estado+"", miConexionBase);
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
        //--->APROBAR PRECIOS
        [WebMethod]
        public bool aprobarPrecio(int idpa, float precioAc)
        {

            SqlCommand comando = new SqlCommand("Update  Paquete set IdEstado= 1 , Precio='"+precioAc+"'where IdPaquete=" + idpa);
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            miConexionBase.Close();
        }
        //--->RECHAZAR PRECIOS
        [WebMethod]
        public bool rechazarPrecio(int idpa)
        {

            SqlCommand comando = new SqlCommand("Update  Paquete set IdEstado= 2, Precio=0 where IdPaquete=" + idpa);
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            miConexionBase.Close();
        }
        //--->OBTENER DATOS DE PRECIO
        [WebMethod]
        public DataSet ObtenerDatosPrecio(int idpa)
        {
            DataSet ds = new DataSet();
           
            miConexionBase = new SqlConnection(cadenaConexion);
            try
            {
                miConexionBase.Open();
                miComandoSQL = new SqlCommand("Select peso, idCategoria from Paquete where IdPaquete='" + idpa + "", miConexionBase);
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
        [WebMethod]
        public float Obtenercat(int idcat)
        {
            SqlCommand comando = new SqlCommand("Select impuesto FROM Categoria where Idcategoria='" + idcat + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            float numero = 0;
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
        public float precioFinal(float peso, float impuesto, float precio)
        {
            float precioq = precio * Convert.ToSingle(7.74);
            float libras = peso * 5;
            float comision = Convert.ToSingle(0.05);
            float parcial = (precioq + libras) * comision;
            float total = parcial + precioq + libras;
            float temporal = (impuesto * precio) / 100;
            float precioAc = total + temporal;
            
            return precioAc;
        }
        [WebMethod]
        public bool crearRegistro(int categoria, int casilla, float peso, float precio,int lote)
        {
           
            SqlCommand comando = new SqlCommand( "Update Paquete set Peso='"+peso+"', Precio='"+precio+"', IdCategoria="+categoria+", IdLote="+lote+" where IdPaquete="+casilla);
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool crearHisPa(String fecha,int Idemp,int idPa,int estado)
        {

            SqlCommand comando = new SqlCommand("Insert into historialPa values('"+fecha+"',"+Idemp+","+idPa+","+estado+")");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [WebMethod]
        public int IdEmp(String user)
        {
            int id = 0;
            miComandoSQL = new SqlCommand("SELECT IdEmpleado FROM Empleado WHERE UsuarioEmpleado = '" + user + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = lector.GetInt32(0);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return id;
        }
        [WebMethod]
        public int ObtenerUltimoLote()
        {
            int id = 0;
            miComandoSQL = new SqlCommand("select MAX(IdLote) from lote");
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = lector.GetInt32(0);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return id;
        }
        [WebMethod]
        public DateTime ObtenerFechaUltimoLote(int idlote)
        {
            DateTime id = new DateTime();
            miComandoSQL = new SqlCommand("select Fechasalida from Lote where idlote="+idlote);
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = lector.GetDateTime(0);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return id;
        }
        [WebMethod]
        public bool CrearLote(String fecha,int idsucursal)
        {

            miComandoSQL = new SqlCommand("Insert into Lote values('" + fecha + "'," + idsucursal+")");
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
        }

        [WebMethod]
        public bool agregarEmpleado(string nombre, string apellido,float sueldo,string tipo,int rol,int habilitado,int idsuc)
        {
            miComandoSQL = new SqlCommand("Insert into Empleado (nombre, apellido,sueldo,tipo,rol,habilitado,idsucursal) values('" + nombre + "','" + apellido +"','"+sueldo +"','"+tipo+"',"+rol+","+habilitado+","+idsuc+")");
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
        }

        [WebMethod]
        public int ObtenerUltimoHis(int emp)
        {
            int id = 0;
            miComandoSQL = new SqlCommand("select MAX(IdEmpleado) from Empleado where IdEmpleado="+emp);
            miConexionBase = new SqlConnection(cadenaConexion);
            miComandoSQL.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = miComandoSQL.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = lector.GetInt32(0);

                }
            }
            lector.Close();
            miConexionBase.Close();
            return id;
        }

        [WebMethod]
        public bool agregarHisEmp(string fechain,int Idemplead,string nombre, string apellido, float sueldo, string tipo, int rol, int habilitado, int idsuc)
        {
            miComandoSQL = new SqlCommand("Insert into historialEmp (Fechainicio,IdEmpleado,nombre, apellido,sueldo,tipo,rol,habilitado,idsucursal) values('" + fechain + "'," + Idemplead + ",'" + nombre + "','" + apellido + "','" + sueldo + "','" + tipo + "'," + rol + "," + habilitado + "," + idsuc + ")");
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
        }
        [WebMethod]
        public bool ActualizarHisEmp(string fechain, int Idemplead, string nombre, string apellido,int telefono, float sueldo,string direccion, string tipo, int rol, string usuarioEmpleado,string PasswordE,int habilitado)
        {
            miComandoSQL = new SqlCommand("Insert into historialEmp values('" + fechain + "'," + Idemplead + ",'" + nombre + "','" + apellido +"',"+telefono+ ",'" + sueldo + "','"+direccion+"','" + tipo + "'," + rol + ",'"+usuarioEmpleado+"','"+PasswordE+"'," + habilitado + ")");
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

        }
        [WebMethod]
        public bool ActualizarHisEmpFn(string fechafn,int id)
        {
            SqlCommand comando = new SqlCommand("Update  historialEmp set  FechaFin='" + fechafn + "' where IdHistorialE="+id);
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            if (comando.ExecuteNonQuery() != 0)
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
        public int obtenerDeptId(String nombre)
        {
            SqlCommand comando = new SqlCommand("Select IdDepartamento FROM Departamento where Nombre='" + nombre + "'");
            miConexionBase = new SqlConnection(cadenaConexion);
            comando.Connection = miConexionBase;
            miConexionBase.Open();
            SqlDataReader lector = comando.ExecuteReader();
            int rol = 0;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    rol = lector.GetInt32(0);

                }
            }
            return rol;
        }



    }
}
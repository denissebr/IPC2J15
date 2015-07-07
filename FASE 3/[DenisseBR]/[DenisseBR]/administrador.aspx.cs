using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class administrador : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        private string msj;
        protected void Page_Load(object sender, EventArgs e)
        {

            userEmp.Text = wsr.obtenerEmp(Convert.ToString(Session["Director"]));
            int rol = wsr.obtenerDept(Convert.ToString(Session["Director"]));
            depto.Text = wsr.nombredept(rol);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            Response.Redirect("reporteAdmin1.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("reporteAdmin2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("top.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;
            string format = "d/MM/yyyy";   // formato
            String fechaAc = time.ToString(format);
            string str = cntra.FileName;
            cntra.PostedFile.SaveAs(Server.MapPath(".") + "/Documentos/contratacion/" + str);
            string path = "~/Documentos/contratacion/" + str.ToString();
            try
            {
                StreamReader leer = new StreamReader(cntra.PostedFile.InputStream);
                string linea;

                while ((linea = leer.ReadLine()) != null)
                {


                    string apellido;
                    string nombre;
                    float sueldo;
                    string sucursal;
                    string departamento;
                    string[] fila;
                    if (linea != "APELLIDOS,NOMBRES,SUELDO,SUCURSAL,DEPARTAMENTO")
                    {

                        fila = linea.Split(',');
                        apellido = fila[0];
                        nombre = fila[1];
                        sueldo = Convert.ToSingle(fila[2]);
                        sucursal = fila[3];
                        departamento = fila[4];
                        int idsuc = wsr.ObtenerSucursal(fila[3]);
                        int idDept = wsr.obtenerDeptId(fila[4]);
                        if (wsr.agregarEmpleado(nombre, apellido, sueldo, "empleado", idDept, 1, idsuc))
                        {
                            int idEmp = wsr.ObtenerUltimoEmp();
                            if (wsr.agregarHisEmp(fechaAc, idEmp, nombre, apellido, sueldo, "empleado", idDept, 1, idsuc))
                            {
                                msj = "Se actualizo el historial de empleados";
                                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                            }
                            else
                            {
                                msj = "Error al actualizar el historial";
                                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                            }
                            msj = "Se realizo la contratacion exitosamente";
                            Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                        }
                        else
                        {
                            msj = "No se pudo realizar la contratacion";
                            Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                        }

                    }
                }
            }


            catch (Exception ex)
            {
                Response.Write("<script language='JavaScript'>window.alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string str = cate.FileName;
            cate.PostedFile.SaveAs(Server.MapPath(".") + "/Documentos/contratacion/" + str);
            string path = "~/Documentos/contratacion/" + str.ToString();
            wsr.cargarCategoria(Server.MapPath(".") + "/Documentos/contratacion/" + str);
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("WebForm1.aspx");
        }

        protected void carga_Click(object sender, EventArgs e)
        {
            cargaMas.Visible = true;
        }
    }
}
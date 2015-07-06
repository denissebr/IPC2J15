using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class director : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        String msj;
        int rol;
        static int idPa;
        static float pre;
        private System.Data.DataSet datasetin;
        private System.Data.DataSet datasetemp;
        private System.Data.DataSet dataseEmp;
        private string[] departamento;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Director"]==null){
                Response.Redirect("WebForm1.aspx");
            }
            else { 
            userEmp.Text = wsr.obtenerEmp(Convert.ToString(Session["Director"]));
            rol = wsr.obtenerDept(Convert.ToString(Session["Director"]));
            if(rol==3){
                btnpre.Enabled = true;
            }
            else
            {
                btnpre.Enabled = false;
                precarga.Visible = false;
            }
            depto.Text = wsr.nombredept(rol);
            int sucursal = wsr.ObtenerSucursalEmpl(Convert.ToString(Session["Director"]));
            datasetin = wsr.mostrarEmpleado(sucursal,rol);
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
            precarga.Visible = false;
            despedirGV.AutoGenerateColumns = true;
            despedirGV.DataSource = datasetin;
            despedirGV.DataBind();
            //departamentos
            ddd.Items.Clear();
            departamento = wsr.departamentos();
            foreach (string dept in departamento)
            {

                ddd.Items.Add(dept);
            }
            datasetemp = wsr.mostrarEquipo(3, rol);
            generalGV.AutoGenerateColumns = true;
            generalGV.DataSource = datasetemp;
            generalGV.DataBind();
            }
        }

        protected void despedirGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = despedirGV.SelectedRow;
            int res = wsr.despedir(Convert.ToInt32(row.Cells[1].Text));
            if(res==1){
                msj = "Empleado " + row.Cells[2].Text + " " + row.Cells[3].Text + " dado de baja";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                rol = wsr.obtenerDept(Convert.ToString(Session["Director"]));
                datasetin = wsr.mostrarEmpleado(1, rol);
                despedirGV.AutoGenerateColumns = true;
                despedirGV.DataSource = datasetin;
                despedirGV.DataBind();
            }
            else
            {
                msj = "Error al dar de baja al empleado";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                rol = wsr.obtenerDept(Convert.ToString(Session["Director"]));
                datasetin = wsr.mostrarEmpleado(1, rol);
                despedirGV.AutoGenerateColumns = true;
                despedirGV.DataSource = datasetin;
                despedirGV.DataBind();
            }

        }

        protected void despedir_Click(object sender, EventArgs e)
        {
            pnlcontra.Visible = false;
            pnldespedir.Visible = true;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
            precarga.Visible = false;
        }


        protected void contratacion_Click(object sender, EventArgs e)
        {
            pnlcontra.Visible = true;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
            precarga.Visible = false;
        }

        protected void equipo_Click(object sender, EventArgs e)
        {
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = false;
            precarga.Visible = false;
        }

        protected void generalGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            msj = "Error al mostrar datos indivudales del empleado";
           /* rol = wsr.obtenerDept(Convert.ToString(Session["Usuario"]));
            datasetemp = wsr.mostrarEquipo(1, rol);
            generalGV.AutoGenerateColumns = true;
            generalGV.DataSource = datasetemp;
            generalGV.DataBind();*/
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = true;
            
            GridViewRow row = generalGV.SelectedRow;
            int codi = Convert.ToInt32(row.Cells[1].Text);
            dataseEmp = wsr.obtenerDatosEmp(codi);
            
            if (dataseEmp != null)
            {
                cod.Text = dataseEmp.Tables[0].Rows[0][0].ToString();
                nom.Text = dataseEmp.Tables[0].Rows[0][1].ToString();
                ape.Text = dataseEmp.Tables[0].Rows[0][2].ToString();
                tel.Text = dataseEmp.Tables[0].Rows[0][3].ToString();
                sueldo.Text = dataseEmp.Tables[0].Rows[0][4].ToString();
                direc.Text = dataseEmp.Tables[0].Rows[0][5].ToString();
                ddd.SelectedItem.Equals(dataseEmp.Tables[0].Rows[0][7].ToString());
                usuarioEmp.Text = dataseEmp.Tables[0].Rows[0][8].ToString();
                txtpass.Text = dataseEmp.Tables[0].Rows[0][9].ToString();
            }
            else
            {

                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            nom.ReadOnly = true;
            ape.ReadOnly = true;
            tel.ReadOnly = true;
            sueldo.ReadOnly = true;
            direc.ReadOnly = true;
            usuarioEmp.ReadOnly = true;
            txtpass.ReadOnly = true;
            ddd.Enabled = false;
            cod.ReadOnly = true;

        }

        protected void btnmod_Click(object sender, EventArgs e)
        {
            cod.ReadOnly = true;
            nom.ReadOnly = false;
            ape.ReadOnly = false;
            tel.ReadOnly = false;
            sueldo.ReadOnly = false;
            direc.ReadOnly = false;
            usuarioEmp.ReadOnly = false;
            txtpass.ReadOnly = false;
            btng.Visible = true;
            btng.Enabled = true;
            ddd.Enabled = true;
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = true;
        }

        protected void btng_Click(object sender, EventArgs e)
        {
            msj = "Datos actualizados exitosamente";
            wsr.ActualizarDatosEmp(nom.Text,ape.Text,Convert.ToInt32(tel.Text),Convert.ToSingle(sueldo.Text),direc.Text,Convert.ToInt32(ddd.SelectedIndex+1),usuarioEmp.Text,txtpass.Text,Convert.ToInt32(cod.Text));
            Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            individual.Visible = false; 
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;

            datasetemp = wsr.mostrarEquipo(1, rol);
            generalGV.AutoGenerateColumns = true;
            generalGV.DataSource = datasetemp;
            generalGV.DataBind();
        }

        protected void btnpre_Click(object sender, EventArgs e)
        {
            precarga.Visible = true;
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = precaGV.SelectedRow;
            idPa = Convert.ToInt32(row.Cells[0].Text);
            pre=Convert.ToSingle(row.Cells[1].Text);
            precarga.Visible = true;
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
        }

        protected void btnap_Click(object sender, EventArgs e)
        {
            float peso=0;
            int cat=0;
            DataSet datos =wsr.ObtenerDatosPrecio(idPa);
            if (datos != null)
            {
                peso = Convert.ToSingle(datos.Tables[0].Rows[0][0]);
                cat = Convert.ToInt32(dataseEmp.Tables[0].Rows[0][1]);

            }

            float impuesto = wsr.Obtenercat(cat);
            float precioAct = wsr.precioFinal(peso,impuesto,pre);
            if (wsr.aprobarPrecio(idPa, precioAct))
            {
                msj = "Paquete aprobado";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                precarga.Visible = true;
                pnlcontra.Visible = false;
                pnldespedir.Visible = false;
                ConsultarEquipo.Visible = false;
                individual.Visible = false;
            }
            else
            {
                msj = "Error al actualizar el dato";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                precarga.Visible = true;
                pnlcontra.Visible = false;
                pnldespedir.Visible = false;
                ConsultarEquipo.Visible = false;
                individual.Visible = false;
            }
            precaGV.DataBind();
        }

        protected void btnre_Click(object sender, EventArgs e)
        {
            if(wsr.rechazarPrecio(idPa)){
                msj = "Paquete rechazado, se regreso al empleado de bodega para revision";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            else
            {

                msj = "Error al actualizar el dato";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            precaGV.DataBind();
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("WebForm1.aspx");
            
        }

        protected void cargar_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now; 
            string format = "d/MM/yyyy";   // formato
            String fechaAc= time.ToString(format); 
            string str = cntra.FileName;
            cntra.PostedFile.SaveAs(Server.MapPath(".") + "/Documentos/contratacion/" + str);
            string path = "~/Documentos/contratacion/" + str.ToString();
            if (cntra.HasFile)
            {
                try
                {
                    StreamReader leer = new StreamReader(cntra.PostedFile.InputStream);
                    string linea;
                    int cont = 0;

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
                            if (cont == 0) { 
                                fila = linea.Split(',');

                                apellido = fila[0];
                                nombre = fila[1];
                                sueldo = Convert.ToSingle(fila[2]);
                                sucursal = fila[3];
                                departamento = fila[4];
                                int idsucursal=wsr.ObtenerSucursal(sucursal);
                                int rol=wsr.obtenerDeptId(departamento);
                                
                                if(wsr.agregarEmpleado(nombre,apellido,sueldo,"empleado",rol,1,idsucursal)){
                                   
                                    int idem = wsr.ObtenerUltimoEmp();
                                    if (wsr.agregarHisEmp(fechaAc,idem))
                                    {
                                        msj = "Se actualizo la tabla de historial de empleados";
                                        Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                                    }

                                    msj = "Se contrataron los empleados con exito";
                                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                                }
                                else
                                {
                                    msj = "No se puede registrar";
                                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                                }
                               
                           }
                             else
                                {
                                    msj = "No se puede registrar el paquete, es necesario crear un nuevo Lote";
                                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                                   

                                }


                        }  

                        }
                    
                }
                catch (Exception ex)
                {
                    msj = "Error en la carga de archivo, verifique que sea formato .CSV y que los campos sean: \n CATEGORIA,IDPAQUETE,PESO,PRECIO";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");

                }
            }
        }





    }
}
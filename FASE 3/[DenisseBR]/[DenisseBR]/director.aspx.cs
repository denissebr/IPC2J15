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
        static int idempleadogen;
        private DataSet TablaHis;
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
            ddd.Items.Clear();
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = false;
            precarga.Visible = false;
            departamento = wsr.departamentos();
            foreach (string dept in departamento)
            {

                ddd.Items.Add(dept);
            }
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
            

            GridViewRow row = generalGV.SelectedRow;
            idempleadogen=Convert.ToInt32(row.Cells[1].Text);
            TablaHis=wsr.perfilIndividual(idempleadogen);
            datosIn.DataSource = TablaHis;
            datosIn.DataBind();


            individual.Visible = true;

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
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
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
            
            int idep=wsr.obtenerDeptId(ddd.SelectedItem.ToString());
            Response.Write(ddd.SelectedItem.ToString());
            if (wsr.ActualizarDatosEmp(nom.Text, ape.Text, Convert.ToInt32(tel.Text), Convert.ToSingle(sueldo.Text), direc.Text, idep, usuarioEmp.Text, txtpass.Text, Convert.ToInt32(cod.Text)))
            {

                msj = "Datos actualizados exitosamente";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            individual.Visible = false; 
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            int id = wsr.ObtenerUltimoHis(Convert.ToInt32(cod.Text));
            DateTime time = DateTime.Now;
            string format = "d/MM/yyyy";   // formato
            String fechafin = time.ToString(format);
            if (wsr.ActualizarHisEmpFn(fechafin, id))
            {
                if (wsr.ActualizarHisEmp(fechafin, Convert.ToInt32(cod.Text), nom.Text, ape.Text, Convert.ToInt32(tel.Text), Convert.ToSingle(sueldo.Text), direc.Text, "empleado", idep, usuarioEmp.Text, txtpass.Text, 1))
                {
                   Response.Write("Hola");
                }
            }
            else
            {
                if (wsr.ActualizarHisEmp(fechafin, Convert.ToInt32(cod.Text), nom.Text, ape.Text, Convert.ToInt32(tel.Text), Convert.ToSingle(sueldo.Text), direc.Text, "empleado", idep, usuarioEmp.Text, txtpass.Text, 1))
                {
                    Response.Write("adios");
                }
            }
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
                                    
                                        fila = linea.Split(',');
                                        apellido = fila[0];
                                        nombre = fila[1];
                                        sueldo = Convert.ToSingle(fila[2]);
                                        sucursal=fila[3];
                                        departamento = fila[4];
                                        int idsuc=wsr.ObtenerSucursal(fila[3]);
                                        int idDept=wsr.obtenerDeptId(fila[4]);
                                        if (wsr.agregarEmpleado(nombre, apellido, sueldo, "empleado", idDept, 1, idsuc))
                                        {
                                            int idEmp=wsr.ObtenerUltimoEmp();
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

            }
        }

        protected void datosIn_SelectedIndexChanged(object sender, EventArgs e)
        {
        }





    }
}
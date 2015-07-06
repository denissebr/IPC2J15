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
    
    public partial class empleado : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        public System.Data.DataSet dataset1;
        public System.Data.DataSet datasetin;
        private string msj;
        private string[] sucursal;
        static long numcasilla;
        private DataSet datasetDev;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Empleado"]==null){
                Response.Redirect("WebForm1.aspx");
            }
            else { 
            userEmp.Text = wsr.obtenerEmp(Convert.ToString(Session["Empleado"]));
            int tipo = wsr.tipoEmp(Convert.ToString(Session["Empleado"]));
            dept.Text = wsr.nombredept(tipo);
            if(tipo==1){
                servicioCliente.Visible = true;
                bodega.Visible = false;
                paquetes.Visible = false;
                datasetin = wsr.clientePendienteApr();
                inactivos.AutoGenerateColumns = true;
                inactivos.DataSource = datasetin;
                inactivos.DataBind();
            }
            else if (tipo == 2)
            {
                servicioCliente.Visible = false;
                bodega.Visible = false;
                paquetes.Visible = true;
            }
            else if (tipo == 3)
            {
                servicioCliente.Visible = false;
                bodega.Visible = true;
                paquetes.Visible = false;
                DataSet dataPrecarga = wsr.mostrarPrecarga();
                precargaGV.DataSource = dataPrecarga;
                precargaGV.DataBind();

            }
            }
           
        }


        protected void facturar_Click(object sender, EventArgs e)
        {
            eyf.Visible = true;
            dev.Visible = false;
            bus.Visible = false;
            aprovar.Visible = false;
        }

        protected void devolucion_Click(object sender, EventArgs e)
        {
            eyf.Visible = false;
            dev.Visible = true;
            bus.Visible = false;
            aprovar.Visible = false;
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
            eyf.Visible = false;
            dev.Visible = false;
            bus.Visible = true;
            aprovar.Visible = false;
        }

        protected void buscarC_Click(object sender, EventArgs e)
        {
            eyf.Visible = false;
            dev.Visible = false;
            aprovar.Visible = false;
            bus.Visible = true;

            dataset1 = wsr.obtenerCasilla(datosc.Text);
            buscarcliente.AutoGenerateColumns = true;
            buscarcliente.DataSource = dataset1;
            buscarcliente.DataBind();
        }

        protected void aprc_Click(object sender, EventArgs e)
        {
            eyf.Visible = false;
            dev.Visible = false;
            bus.Visible = false;
            aprovar.Visible = true;
           
           

            

        }

        protected void inactivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = inactivos.SelectedRow;
            

            int res=wsr.ActualizarEstado(Convert.ToInt64(row.Cells[3].Text));

            msjAcc.Visible = true;
            if(res==1){
     
                inactivos.SelectedIndex = -1;
                aprovar.Visible = true;
                msjAcc.Text = "Cliente: " + row.Cells[1].Text + " " + row.Cells[2].Text + " aprobado";
                datasetin = wsr.clientePendienteApr();
                inactivos.AutoGenerateColumns = true;
                inactivos.DataSource = datasetin;
                inactivos.DataBind();
               
            }
            else
            {
                datasetin = wsr.clientePendienteApr();
                inactivos.AutoGenerateColumns = true;
                inactivos.DataSource = datasetin;
                inactivos.DataBind();
                inactivos.SelectedIndex = -1;
                aprovar.Visible = true;
                msjAcc.Text = "Error al aprobar el cliente";
            }
            eyf.Visible = false;
            dev.Visible = false;
            bus.Visible = false;
           

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idpa.Visible = true;
            precio.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            apr.Visible = true;
            GridViewRow row = precargaGV.SelectedRow;
            idpa.Text = (row.Cells[0].Text);
            pnlprecar.Visible = true;



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            pnlprecar.Visible = true;
        }

        protected void devolverBtn_Click(object sender, EventArgs e)
        {

        }

        protected void apr_Click(object sender, EventArgs e)
        {
            int estado=3;
            if (wsr.actualizarPrecio(Convert.ToInt32(idpa.Text), Convert.ToSingle(precio.Text), estado))
            {
                msj = "Precio actualizado";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            else
            {
                msj = "Error al actualizar el dato";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            precargaGV.DataBind();
            pnlprecar.Visible = true;
            idpa.Visible = false;
            precio.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            apr.Visible = false;
            
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("WebForm1.aspx");
        }

        protected void rp_Click(object sender, EventArgs e)
        {
            registro.Visible = true;
            lote.Visible = false;
        }

        protected void btnC_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now; 
            string format = "d/MM/yyyy";   // formato
            String fecha= time.ToString(format); 
           
            string str = regisF.FileName;
            regisF.PostedFile.SaveAs(Server.MapPath(".") + "/Documentos/registro/" + str);
            string path = "~/Documentos/registro/" + str.ToString();
            if(regisF.HasFile){
                try
                {
                    StreamReader leer = new StreamReader(regisF.PostedFile.InputStream);
                    string linea;
                    int cont = 0;

                    while ((linea = leer.ReadLine()) != null)
                    {
                        

                                    string categoria;
                                    float peso;
                                    float precio;
                                    int idPaquete;
                                    string[] fila;
                                    if (linea != "CATEGORIA,IDPAQUETE,PESO,PRECIO")
                                    {
                                        if (cont == 0)
                                        {
                                            fila = linea.Split(',');
                                            categoria = fila[0];
                                            idPaquete = Convert.ToInt32(fila[1]);
                                            peso = Convert.ToSingle(fila[2]);
                                            precio = Convert.ToSingle(fila[3]);
                                            int idcat=wsr.Obtenericcat(categoria);
                                            int idlot = wsr.ObtenerUltimoLote();
                                            DateTime fechaLot = wsr.ObtenerFechaUltimoLote(idlot);
                                            String fecha2=fechaLot.ToString(format);
                                            int compara = String.Compare(fecha,fecha2);
                                            Response.Write(fecha +" "+fecha2);
                                            if(compara<=0){
                                                if (wsr.crearRegistro(idcat, idPaquete, peso, precio,idlot))
                                                {
                                                 int idemp = wsr.IdEmp(Convert.ToString(Session["Empleado"]));
                                                 if (wsr.crearHisPa(fecha, idemp, idPaquete, 3))
                                                 {
                                                 msj = "informacion del paquete actualizada";
                                                 Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                                                 }
                                                 }
                                            }
                                            
                                            else
                                            {
                                                msj = "No se puede registrar el paquete, es necesario crear un nuevo Lote";
                                                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                                                ap.Enabled = true;
                                                 
                                            }
                                          
                                           
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

        protected void ap_Click(object sender, EventArgs e)
        {
            sucursal = wsr.Sucursal();
            foreach (string sucur in sucursal)
            {

                ddsucr.Items.Add(sucur);
            }
        }

        protected void crearLot_Click(object sender, EventArgs e)
        {
            
            string format = "d/MM/yyyy";   // formato
            fechatxt.Text = DateTime.Now.ToString(format);
            
            int idsuc = wsr.ObtenerSucursal(Convert.ToString(ddsucr.SelectedItem));
            if (wsr.CrearLote(fechatxt.Text, idsuc))
            {
                msj = "Lote creado exitosamente";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            else
            {

                msj = "Error inesperado al crear el Lote";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
        }

        protected void datosc_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void btncasdev_Click(object sender, EventArgs e)
        {
            numcasilla =wsr.devolverDPI(Convert.ToInt32(paqueteNo.Text));
            datasetDev=wsr.tablaDevolver(numcasilla);
            devolver.DataSource = datasetDev;
            devolver.DataBind();
            dev.Visible = true;
            lote.Visible = false;
            eyf.Visible = false;
            dev.Visible = true;
            aprovar.Visible = false;
            bus.Visible = false;
        }

        protected void devolver_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = devolver.SelectedRow;
            int paquete=Convert.ToInt32(row.Cells[2].Text);
            DateTime time = DateTime.Now; 
            string format = "d/MM/yyyy";   // formato
            String fecha= time.ToString(format); 
            int idemp = wsr.IdEmp(Convert.ToString(Session["Empleado"]));
            if (wsr.crearHisPa(fecha, idemp, paquete, 7))
            {

                msj = "El paquete ha sido devuelto";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            else
            {

                msj = "Error al actualizar la informacion";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            devolver.DataBind();
            eyf.Visible = false;
            dev.Visible = true;
            aprovar.Visible = false;
            bus.Visible = false;
        }

        protected void deliver_Click(object sender, EventArgs e)
        {
            eyf.Visible = true;
            dev.Visible = false;
            aprovar.Visible = false;
            bus.Visible = false;
        }

        protected void btnbc_Click(object sender, EventArgs e)
        {
            eyf.Visible = true;
            dev.Visible = false;
            aprovar.Visible = false;
            bus.Visible = false;
        }


    }
}
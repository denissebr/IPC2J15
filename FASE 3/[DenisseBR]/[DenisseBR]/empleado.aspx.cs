using System;
using System.Collections.Generic;
using System.Data;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            userEmp.Text = wsr.obtenerEmp(Convert.ToString(Session["Empleado"]));
            userEmp0.Text = wsr.obtenerEmp(Convert.ToString(Session["Empleado"]));
            int tipo = wsr.tipoEmp(Convert.ToString(Session["Empleado"]));
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
            eyf.Visible = true;
            dev.Visible = false;
            bus.Visible = false;
            aprovar.Visible = false;
            pnlprecar.Visible = false;
           
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

            dataset1=wsr.obtenerCasilla(datosc.Text);
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

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            pnlprecar.Visible = true;
        }

        protected void devolverBtn_Click(object sender, EventArgs e)
        {

        }


    }
}
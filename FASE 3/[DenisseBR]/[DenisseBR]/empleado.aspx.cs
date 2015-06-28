using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    
    public partial class empleado : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        private System.Data.DataSet dataset1;
        protected void Page_Load(object sender, EventArgs e)
        {
            eyf.Visible = true;
            dev.Visible = false;
            bus.Visible = false;
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void facturar_Click(object sender, EventArgs e)
        {
            eyf.Visible = true;
            dev.Visible = false;
            bus.Visible = false;
        }

        protected void devolucion_Click(object sender, EventArgs e)
        {
            eyf.Visible = false;
            dev.Visible = true;
            bus.Visible = false;
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
            eyf.Visible = false;
            dev.Visible = false;
            bus.Visible = true;
        }

        protected void buscarC_Click(object sender, EventArgs e)
        {
            dataset1=wsr.obtenerCasilla(datosc.Text);
            buscarcliente.AutoGenerateColumns = true;


            buscarcliente.DataSource = dataset1;
            buscarcliente.DataBind();
           
 
        }
    }
}
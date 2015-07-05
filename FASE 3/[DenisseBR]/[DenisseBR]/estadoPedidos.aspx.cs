using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class estadoPedidos : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        private System.Data.DataSet datoIn;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioN.Text = wsr.obtenerUs(Convert.ToString(Session["Usuario"]));
            int idpa=Convert.ToInt32(Session["IdPaquete"]);
            datoIn = wsr.mostrarDatosPedIn(idpa);
            pain.DataSource = datoIn;
            pain.DataBind();
            


        }
    }
}
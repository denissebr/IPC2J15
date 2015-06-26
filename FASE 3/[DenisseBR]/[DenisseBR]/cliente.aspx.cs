using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace _DenisseBR_
{
    public partial class cliente : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            //usuarioN.Text = Convert.ToString(Session["Usuario"]);
            usuarioN.Text =wsr.obtenerUs(Convert.ToString(Session["Usuario"]), "cliente");
            pnlpedido.Visible = false;
            pnlcot.Visible = false;
        }

        protected void end_Click(object sender, EventArgs e)
        {
            Session["Active Users"] = -1;
            Response.Redirect("WebForm1.aspx");
        }

       

        protected void cotizar_Click(object sender, EventArgs e)
        {
            pnlpedido.Visible = false;
            pnlcot.Visible = true;
        }

        protected void pedido_Click(object sender, EventArgs e)
        {
            pnlpedido.Visible = true;
            pnlcot.Visible = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _denissebr201224240_
{
    public partial class modi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            websr.Service1SoapClient wsr = new websr.Service1SoapClient();
            usuarioN.Text = wsr.DevolverNombreCliente(Convert.ToString(Session["Usuario"]));
        }
    }
}
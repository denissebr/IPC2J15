using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class reporteAdmin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReportViewer1.RefreshReport();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrador.aspx");
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_JDBR
{
    public partial class administrador : System.Web.UI.Page
    {

        WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cargar_Click(object sender, EventArgs e)
        {
            String direccionCSV = Server.MapPath(FileUpload1.FileName);
            wsr.cargarEmpleado(direccionCSV);
           

        }

        protected void cimp_Click(object sender, EventArgs e)
        {
            String direccionCSV = Server.MapPath(FileUpload1.FileName);
            wsr.cargarCategoria(direccionCSV);
        }

    }
}
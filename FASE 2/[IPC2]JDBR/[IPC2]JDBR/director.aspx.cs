using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_JDBR
{
    public partial class director : System.Web.UI.Page
    {
        WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cargaEmpleado_Click(object sender, EventArgs e)
        {
            
            String direccion = Server.MapPath(FileUpload1.FileName);
            wsr.cargarEmpleado(direccion);
        }

        protected void baja_Click(object sender, EventArgs e)
        {
            wsr.despedir(id.Text);
            id.Text = "";
        }
    }
}
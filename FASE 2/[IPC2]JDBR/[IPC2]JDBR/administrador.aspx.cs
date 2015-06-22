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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cargar_Click(object sender, EventArgs e)
        {
            WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
            String direccionCSV = Server.MapPath(FileUpload1.FileName);
            
            if(lista.Equals("Impuesto")){
                wsr.cargarCategoria(direccionCSV);

                      }
            else if(lista.Equals("Empleado"))
            {
                wsr.cargarEmpleado(direccionCSV);
            }
            
           

        }

    }
}
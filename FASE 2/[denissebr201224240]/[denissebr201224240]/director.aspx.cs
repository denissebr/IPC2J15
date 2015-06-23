using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _denissebr201224240_
{
    public partial class director : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            websr.Service1SoapClient wsr = new websr.Service1SoapClient();
            wsr.despedir(baja.Text);
            baja.Text = "";
            msj.Visible = true;
        }

        protected void carga_Click(object sender, EventArgs e)
        {

            if (cargarEmp.HasFile)
            {
                cargarEmp.SaveAs(MapPath("Archivos/" + cargarEmp.FileName));
                websr.Service1SoapClient wsr = new websr.Service1SoapClient();
                String path = MapPath("Archivos/" + cargarEmp.FileName); ;
                wsr.cargarEmpleado(path);


            }

        }
    }
}
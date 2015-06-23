using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _denissebr201224240_
{
    public partial class admin : System.Web.UI.Page
    {
     
        websr.Service1SoapClient wsr = new websr.Service1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cargar_Click(object sender, EventArgs e)
        {
            if (archivo.HasFile)
            {
                String path;
                archivo.SaveAs(MapPath("Archivos/" + archivo.FileName));
                websr.Service1SoapClient wsr = new websr.Service1SoapClient();
                if (ddo.SelectedIndex.Equals(0))
                {
                    path = MapPath("Archivos/" + archivo.FileName); 
                    wsr.cargarEmpleado(path);
                }
                else if(ddo.SelectedIndex.Equals(1))
                {
                    path = MapPath("Archivos/" + archivo.FileName); 
                    wsr.cargarCategoria(path);
                }


            }

                        }
            

    
    }
}
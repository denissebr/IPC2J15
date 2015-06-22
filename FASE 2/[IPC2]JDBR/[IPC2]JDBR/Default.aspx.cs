using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_JDBR
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cotizar_Click(object sender, EventArgs e)
        {

            float precio = Convert.ToSingle(costo.Text);
            float libras = Convert.ToSingle(peso.Text);
            WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
            String prueba=wsr.cotizar(precio,libras);  
            lblprecio.Visible = true;
            Label5.Visible = true;
            lblprecio.Text = "Q"+prueba;
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }


      
    }
}
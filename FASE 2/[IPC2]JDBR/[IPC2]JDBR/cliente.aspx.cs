using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Input;


namespace _IPC2_JDBR
{
    public partial class cliente : System.Web.UI.Page
    {

     List<string> lista = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

            WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
            lista = wsr.Categorias();
            foreach (string categoria in lista)
            {
                DropDownList1.Items.Add(categoria);
            }
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(!peso.Text.Equals("")&&!precio.Text.Equals("")){
                error.Visible = false;
                float costo = Convert.ToSingle(precio.Text);
                float libras = Convert.ToSingle(peso.Text);
                WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
                String prueba = wsr.cotizar(costo, libras);
                total.Visible = true;
                total.Text = "Q" + prueba;
            }
            else
            {
                error.Visible = true;
            }
            
        }
    }
}
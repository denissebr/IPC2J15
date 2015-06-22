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
        
        WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

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
                String prueba = wsr.cotizar(costo, libras);
                String seleccion=DropDownList1.SelectedItem.ToString();
                seleccion=seleccion.Replace('%',' ');
                string[] aux=seleccion.Split('-');
                float valor = float.Parse(aux[1]);
                float temporal = (valor * costo) / 100;
                float totalf = Convert.ToSingle(prueba) + temporal;
                total.Visible = true;
                total.Text = "Q" + totalf.ToString();
            }
            else
            {
                error.Visible = true;
            }
            
        }
    }
}
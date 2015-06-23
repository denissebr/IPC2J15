using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _denissebr201224240_
{
    public partial class cliente : System.Web.UI.Page
    {
        List<string> lista = new List<string>();
        List<string> lista2 = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            websr.Service1SoapClient wsr = new websr.Service1SoapClient();
            username.Text = wsr.DevolverNombreCliente(Convert.ToString(Session["Usuario"]));

            
            
            lista = wsr.Categorias();

            foreach (string categoria in lista)
            {
                
                DropDownList2.Items.Add(categoria);
            }
            lista2 = wsr.Categorias();
            foreach (string categoria in lista2)
            {

                DropDownList1.Items.Add(categoria);
            }


        }


        protected void cotizar_Click(object sender, EventArgs e)
        {
            websr.Service1SoapClient wsr = new websr.Service1SoapClient();
            if (!peso.Text.Equals("") && !precio.Text.Equals(""))
            {
                
                float costo = Convert.ToSingle(precio.Text);
                float libras = Convert.ToSingle(peso.Text);
                
                String prueba = wsr.cotizar(costo, libras);
                String seleccion = DropDownList2.SelectedItem.ToString();
                seleccion = seleccion.Replace('%', ' ');
                string[] aux = seleccion.Split('-');
                float valor = float.Parse(aux[1]);
                float temporal = (valor * costo) / 100;
                float totalf = Convert.ToSingle(prueba) + temporal;
                precioF.Visible = true;
                precioF.Text = "Q" + totalf.ToString();
            }
           
        }
    }
}
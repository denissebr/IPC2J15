using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        List<string> lista = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel1.Visible = true;
            Session["Activos"] = 0;

            ddt.Items.Clear();
            lista = wsr.Categorias();

            foreach (string categoria in lista)
            {
                
                ddt.Items.Add(categoria);
            }
            
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel2.Visible=true;

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = true;
            Panel1.Visible = false;
        }

        protected void cot_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel1.Visible = true;
        }

        protected void logIn_Click(object sender, EventArgs e)
        {
            

            if (wsr.logC(usuario.Text, passw.Text))
            {
                Session["Activos"] = Convert.ToInt32(Session["number"]) + 1;
                Session["Usuario"] = usuario.Text;
                Response.Redirect("cliente.aspx");
            }
            else
            {
                msj.Text = "ERROR \n datos incorrecto";
            }

        }

        protected void cotizar_Click(object sender, EventArgs e)
        {
            float costo = Convert.ToSingle(precio.Text);
            float libras = Convert.ToSingle(peso.Text);
            String seleccion = ddt.SelectedItem.ToString();
            seleccion=seleccion.Replace('%',' ');
            String [] aux= seleccion.Split('-');
            float tipo = float.Parse(aux[1]);

            /*float costo = Convert.ToSingle(precio.Text);
            float libras = Convert.ToSingle(peso.Text);

            String prueba = wsr.cotizar(costo, libras);
            String seleccion = DropDownList2.SelectedItem.ToString();
            seleccion = seleccion.Replace('%', ' ');
            string[] aux = seleccion.Split('-');
            float valor = float.Parse(aux[1]);
            float temporal = (valor * costo) / 100;
            float totalf = Convert.ToSingle(prueba) + temporal;
            precioF.Visible = true;
            precioF.Text = "Q" + totalf.ToString();*/
        }
    }
}
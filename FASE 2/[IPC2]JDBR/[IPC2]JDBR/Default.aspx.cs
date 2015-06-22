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
        WebServiceRef.Service1SoapClient wsr = new WebServiceRef.Service1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cotizar_Click(object sender, EventArgs e)
        {

            float precio = Convert.ToSingle(costo.Text);
            float libras = Convert.ToSingle(peso.Text);
            
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
           
            bool cliente=wsr.loginC(user.Text,passw.Text);
            int empleado = wsr.loginE(user.Text, passw.Text);
            int admin = wsr.loginA(user.Text, passw.Text);
            int director = wsr.loginD(user.Text, passw.Text);
            
            if (cliente ==true)
            {
                
                Response.Redirect("cliente.aspx");
                
            }
            else
            {
                if (admin == 3)
                {
                    Response.Redirect("administrador.aspx");
                }
                else
                {
                    if (director == 2)
                    {
                        Response.Redirect("director.aspx");
                    }
                    else
                    {
                        if (empleado == 1)
                        {
                            Response.Redirect("empleado.aspx");
                        }
                        else
                        {
                            Response.Write("ERROR FATAL");
                        }
                    }
                }
            }

           
            
            
            
        }


      
    }
}
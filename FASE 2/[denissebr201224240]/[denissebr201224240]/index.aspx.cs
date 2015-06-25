using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _denissebr201224240_
{
    public partial class index : System.Web.UI.Page
    {
        websr.Service1SoapClient wsr = new websr.Service1SoapClient();
        List<string> lista = new List<string>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lista = wsr.sucursal();

            foreach (string sucursal in lista);
            {
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(user.Text + passw.Text);

            if(!user.Text.Equals("")&&!passw.Text.Equals("")){
            
            bool cliente = wsr.logC(user.Text, passw.Text);
            int  emp=wsr.logE(user.Text,passw.Text);
            bool dir = wsr.logD(user.Text,passw.Text);
            bool admin=wsr.logA(user.Text,passw.Text);
           
            if (cliente == true)
            {
                Session["Usuario"] = user.Text;
               
                Response.Redirect("cliente.aspx");
            }
            else
            {
                if (admin == true)
                {
                    Response.Redirect("admin.aspx");
                }
                else
                {
                    if(dir==true){
                        Response.Redirect("director.aspx");
                    }
                    else
                    {
                        if(emp==1){
                            Response.Redirect("empleado.aspx");
                        }
                        else
                        {
                            error.Visible = true;
                        }
                    }
                }
            }
           }
            else
            {
                error.Visible = true;
            }
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          /*wsr.registrar(){

          }  */
        }

    }
    }

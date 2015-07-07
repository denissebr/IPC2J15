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
        private string[] lista;
        private string[] sucursal;
        private string msje;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;

            
            lista = wsr.Categorias();
            sucursal = wsr.Sucursal();
           
           
           
            
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Panel3.Visible = false;
            Panel2.Visible=true;

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dds.Items.Clear();
            Panel2.Visible = false;
            Panel3.Visible = true;
            foreach (string sucur in sucursal)
            {

                dds.Items.Add(sucur);
            }
        }


        protected void logIn_Click(object sender, EventArgs e)
        {
            

            if (wsr.logC(usuario.Text, passw.Text))
            {
                Session["ActivaC"] = 1;
                Session["Usuario"] = usuario.Text;
                Response.Redirect("cliente.aspx");
            }
            else
            {
                if(wsr.logE(usuario.Text,passw.Text)){
                    Session["Empleado"] = usuario.Text;
                    Response.Redirect("empleado.aspx");
                }
                else
                {
                    if (wsr.logD(usuario.Text, passw.Text))
                    {
                        Session["Director"] = usuario.Text;
                        Response.Redirect("director.aspx");
                    }
                    else
                    {
                        if (wsr.logA(usuario.Text, passw.Text))
                        {
                            Session["Administrador"] = usuario.Text;
                            Response.Redirect("administrador.aspx");
                        }
                        else
                        {
                            msj.Text = "ERROR \n datos incorrecto";
                        }
                    }
                   
                }
            }
            Panel2.Visible = true;
            Panel3.Visible = false;
        }

    

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = true;
            // public String registrarUs(String nombre, String apellido, long dpi, int telefono,String direccion,bool estado,String usuario,String passw,int IdSucursal)

            int idSucursal = wsr.ObtenerSucursal(Convert.ToString(dds.SelectedItem));
            if (wsr.verificarUs(txtuser.Text))
            {
                msjerrus.Text = "EL USUARIO YA EXISTE, ELIJA OTRO NOMBRE DE USUARIO";
            }
            else
            {
                wsr.registrarUS(nombre.Text, apellido.Text, Convert.ToInt64(DPI.Text), Convert.ToInt32(telefono.Text), Convert.ToInt32(nit.Text), direccion.Text, 0, txtuser.Text, txtpass.Text, idSucursal, Convert.ToInt64(noTarjeta.Text));
                msje = "Usuario registrado exitosamente";
                Response.Write("<script language='JavaScript'>window.alert('" + msje + "');</script>");
                nombre.Text = "";
                apellido.Text = "";
                DPI.Text = "";
                telefono.Text = "";
                nit.Text = "";
                direccion.Text = "";
                txtuser.Text = "";
                txtpass.Text = "";
                noTarjeta.Text = "";
                dds.ClearSelection();
            }   
        }

    
    }
}
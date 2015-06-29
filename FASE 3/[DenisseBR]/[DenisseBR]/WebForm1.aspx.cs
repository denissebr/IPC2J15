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
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel1.Visible = true;
            Session["Activos"] = 0;

            ddt.Items.Clear();
            dds.Items.Clear();
            lista = wsr.Categorias();
            sucursal = wsr.Sucursal();


            foreach (string categoria in lista)
            {
                
                ddt.Items.Add(categoria);
            }
            foreach (string sucur in sucursal)
            {

                dds.Items.Add(sucur);
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
                
                Session["Usuario"] = usuario.Text;
                Response.Redirect("cliente.aspx");
            }
            else
            {
                if(wsr.logE(usuario.Text,passw.Text)){
                    Session["Usuario"] = usuario.Text;
                    Response.Redirect("empleado.aspx");
                }
                else
                {
                    if (wsr.logD(usuario.Text, passw.Text))
                    {
                        Session["Usuario"] = usuario.Text;
                        Response.Redirect(" ");
                    }
                    else
                    {
                        if (wsr.logA(usuario.Text, passw.Text))
                        {
                            Session["Usuario"] = usuario.Text;
                            Response.Redirect("");
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
            Panel1.Visible = false;
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

        protected void regitrarUs_Click(object sender, EventArgs e)
        {
               
            
         }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Panel1.Visible = false;
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
                wsr.registrarUS(nombre.Text, apellido.Text, Convert.ToInt64(DPI.Text), Convert.ToInt32(telefono.Text), Convert.ToInt32(nit.Text), direccion.Text, 0, txtuser.Text, txtpass.Text, idSucursal);
                msjsi.Text = "Usuario Registrado exitosamente";


            }   
        }

    
    }
}
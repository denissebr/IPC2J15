using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace _DenisseBR_
{
    public partial class cliente : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        private string[] lista;
        private string[] lista1;
        String msj;
        protected void Page_Load(object sender, EventArgs e)
        {
            //usuarioN.Text = Convert.ToString(Session["Usuario"]);
            
            
            usuarioN.Text =wsr.obtenerUs(Convert.ToString(Session["Usuario"]));
            int sucur = wsr.sucursalPedido(Convert.ToString(Session["Usuario"]));
           
            nSucursal.Text = wsr.direccionSucur(sucur);
            lista = wsr.Categorias();
            lista1 = wsr.Categorias();

           
          
            pnlpedido.Visible = false;
            pnlcot.Visible = false;
        }


        protected void end_Click(object sender, EventArgs e)
        {
            Session["Active Users"] = -1;
            Response.Redirect("WebForm1.aspx");
        }

       

        protected void cotizar_Click(object sender, EventArgs e)
        {
            pnlpedido.Visible = false;
            pnlPedidos.Visible = false;
            pnlcot.Visible = true;
            foreach (string categoria in lista)
            {

                ddt.Items.Add(categoria);
            }
        }

        protected void pedido_Click(object sender, EventArgs e)
        {
            pnlpedido.Visible = true;
            pnlcot.Visible = false;
            pnlPedidos.Visible = false;
            foreach (string categoria in lista1)
            {

                ddt1.Items.Add(categoria);
            }
        }

        protected void estados_Click(object sender, EventArgs e)
        {
            pnlpedido.Visible = false;
            pnlcot.Visible = false;
            pnlPedidos.Visible = true;
        }

        protected void linkd_Click(object sender, EventArgs e)
        {
            Response.Redirect("actualizar.aspx");
        }

        protected void btncot_Click(object sender, EventArgs e)
        {
            float precio = Convert.ToSingle(txtprecio.Text);
            float peso = Convert.ToSingle(txtpeso.Text);
            String tipo = Convert.ToString(ddt.SelectedItem);
            tipo=tipo.Replace('%',' ');
            string[] aux = tipo.Split('-');
            float valor = float.Parse(aux[1]);
            lblprecio.Text=wsr.cotizar(precio, peso, valor);

            pnlpedido.Visible = false;
            pnlcot.Visible = true;
            pnlPedidos.Visible = false;

        }

        protected void crear_Click(object sender, EventArgs e)
        {
            String tipo = ddt1.SelectedItem.ToString();
            tipo = tipo.Replace('%', ' ');
            string[] aux = tipo.Split('-');
            int idcat = wsr.Obtenericcat(Convert.ToString(aux[0]));
            float valor = Convert.ToSingle(aux[1]);
            if (precarga.HasFile && txtprecio1.Text.Equals(null))
            {
                long dpiUS = wsr.obtenerDPI(Convert.ToString(Session["Usuario"]));
                int estadoF=2;
                string str = precarga.FileName;
                precarga.PostedFile.SaveAs(Server.MapPath(".") + "//precarga//" + str);
                string path = "//precarga//" + str.ToString();
                if (wsr.PedidoPrecioF(nombre.Text, txtdescripcion.Text, Convert.ToSingle(txtpeso1.Text), path, dpiUS, idcat, estadoF))
                {

                    msj = "Precarga de imagen pendiente de aprovacion";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                    txtprecio1.Text = "";
                    txtpeso1.Text = "";
                    nombre.Text = "";
                    txtdescripcion.Text = "";
                }
                else
                {
                    msj = "Error inesperado, intentelo de nuevo";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                }
            }
            else if (!precarga.HasFile && !txtprecio1.Text.Equals(null))
            {
                float precio = Convert.ToSingle(txtprecio1.Text);
                long dpiUS = wsr.obtenerDPI(Convert.ToString(Session["Usuario"]));
                int estadoF=1;
                if (wsr.PedidoPrecio(nombre.Text, txtdescripcion.Text, Convert.ToSingle(txtpeso1.Text), Convert.ToSingle(txtprecio1.Text), dpiUS, idcat, estadoF,valor))
                {

                    msj = "Pedido Creado Exitosamente";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                    txtprecio1.Text = "";
                    txtpeso1.Text = "";
                    nombre.Text = "";
                    txtdescripcion.Text = "";
                }
                else
                {
                    msj = "Error inesperado, intentelo de nuevo";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                }
             }
           
            pnlpedido.Visible = true;
            pnlcot.Visible = false;
            pnlPedidos.Visible = false;
            
        }
       
       


    }
}

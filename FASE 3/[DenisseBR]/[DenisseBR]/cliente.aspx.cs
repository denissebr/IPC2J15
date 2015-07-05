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
        private string[] lista2;
        public static int sucur;
        String msj;
        private System.Data.DataSet pedidos;
        protected void Page_Load(object sender, EventArgs e)
        {
            //usuarioN.Text = Convert.ToString(Session["Usuario"]);
            if (Session["Usuario"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else { 
            usuarioN.Text =wsr.obtenerUs(Convert.ToString(Session["Usuario"]));
            sucur = wsr.sucursalPedido(Convert.ToString(Session["Usuario"]));
           
            nSucursal.Text = wsr.direccionSucur(sucur);
            Label24.Text = wsr.direccionSucur(sucur);
            lista = wsr.Categorias();
            lista1 = wsr.Categorias(); 
            lista2 = wsr.Categorias();

            long dpiUS = wsr.obtenerDPI(Convert.ToString(Session["Usuario"]));
            pedidos = wsr.mostrarDatosPed(dpiUS);
            pedidoGV.DataSource = pedidos;
            pedidoGV.DataBind();
          
            pnlpedido.Visible = false;
            pnlcot.Visible = false;
            precarga.Visible = false;
            pnlPedidos.Visible = false;

            }
           
           
        }


        protected void end_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("WebForm1.aspx");
        }

       

        protected void cotizar_Click(object sender, EventArgs e)
        {
            ddt.Items.Clear();
            pnlpedido.Visible = false;
            pnlPedidos.Visible = false;
            pnlcot.Visible = true;
            precarga.Visible = false;
            foreach (string categoria in lista)
            {

                ddt.Items.Add(categoria);
            }
           
        }

        protected void pedido_Click(object sender, EventArgs e)
        {
            ddt1.Items.Clear();
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
            precarga.Visible = false;

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
            precarga.Visible = false;
            
        }

        protected void crear_Click(object sender, EventArgs e)
        {
            String tipo = ddt1.SelectedItem.ToString();
            tipo = tipo.Replace('%', ' ');
            string[] aux = tipo.Split('-');

            int idcat = wsr.Obtenericcat(Convert.ToString(aux[0]));
            float valor = Convert.ToSingle(aux[1]);
            long dpiUS = wsr.obtenerDPI(Convert.ToString(Session["Usuario"]));

            int estadoF = 1;
            if (wsr.PedidoPrecio(nombre.Text, txtdescripcion.Text, Convert.ToSingle(txtpeso1.Text), Convert.ToSingle(txtprecio1.Text), dpiUS, idcat, estadoF, valor, sucur))
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
            pnlpedido.Visible = true;
            pnlcot.Visible = false;
            pnlPedidos.Visible = false;
            precarga.Visible = false;
           
        }

        protected void pedido0_Click(object sender, EventArgs e)
        {

            ddt2.Items.Clear();
            pnlpedido.Visible = false;
            pnlcot.Visible = false; ;
            pnlPedidos.Visible = false;
            precarga.Visible = true;
            foreach (string categoria in lista2)
            {

                ddt2.Items.Add(categoria);
            }
        }


        protected void btnprecar_Click(object sender, EventArgs e)
        {
            String tipo = ddt2.SelectedItem.ToString();
            tipo = tipo.Replace('%', ' ');
            string[] aux = tipo.Split('-');

            int idcat = wsr.Obtenericcat(Convert.ToString(aux[0]));
            float valor = Convert.ToSingle(aux[1]);
            long dpiUS = wsr.obtenerDPI(Convert.ToString(Session["Usuario"]));

            if(pre.HasFile){
                                
                int estadoF=2;
                string str = pre.FileName;
                pre.PostedFile.SaveAs(Server.MapPath(".") + "/precarga/fotos/" + str);
                string path = "~/precarga/fotos/" + str.ToString();
                if (wsr.PedidoPrecioF(nombrep.Text, descp.Text, Convert.ToSingle(pesp.Text), path, dpiUS, idcat, estadoF, sucur))
                {

                    msj = "Precarga de imagen pendiente de aprovacion";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                    nombrep.Text = "";
                    descp.Text = "";
                    pesp.Text = "";
                }
                else
                {
                    msj = "Error inesperado, intentelo de nuevo";
                    Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                }
            }

            pnlpedido.Visible = false;
            pnlcot.Visible = false;
            pnlPedidos.Visible = false;
            precarga.Visible = true;
            
        }

        protected void pedidoGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = pedidoGV.SelectedRow;
            int idPaquete = Convert.ToInt32(row.Cells[2].Text);
            Session["IdPaquete"] = idPaquete;
            
            Response.Redirect("estadoPedidos.aspx");
        }

       
       


    }
}

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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cotizar_Click(object sender, EventArgs e)
        {
            float precio = Convert.ToSingle(costo.Text);
            float libras = Convert.ToSingle(peso.Text);
            float precioL = libras *(5);
            Response.Write( "Precio libras "+precioL);
            Response.Write("Precio Producto "+precio);
            float precioq = precio * Convert.ToSingle(7.74);
            Response.Write("Precio Q"+precioq);
            float comision = Convert.ToSingle(0.05);
            float parcial = (precioq + precioL) * comision;
            Response.Write("Precio comision " + parcial);
            float total = parcial + precioq + precioL;
            lblprecio.Visible = true;
            Label5.Visible = true;
            lblprecio.Text = "Q"+Convert.ToString(total);
            
        }
    }
}
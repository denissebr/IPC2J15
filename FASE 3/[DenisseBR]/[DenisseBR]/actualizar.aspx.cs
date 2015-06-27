using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
           
    public partial class actualizar : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        private System.Data.DataSet dataset1;
        private long dato;
        private string[] sucursal;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            dds.Items.Clear();
            sucursal = wsr.Sucursal();
            foreach (string sucur in sucursal)
            {

                dds.Items.Add(sucur);
            }
            

        }

        protected void regitrarUs_Click(object sender, EventArgs e)
        {

            

            int idsuc=wsr.ObtenerSucursal(Convert.ToString(dds.SelectedItem));

            wsr.ActualizarDatos(nombre.Text, apellido.Text, Convert.ToInt64(DPI.Text), Convert.ToInt32(telefono.Text), Convert.ToInt32(nit.Text), direccion.Text, txtuser.Text, txtpass.Text, idsuc);
            
                nombre.Text = "";
                apellido.Text = "";
                DPI.Text = "";
                telefono.Text = "";
                nit.Text = "";
                direccion.Text = "";
                txtuser.Text = "";
                txtpass.Text = "";
            
            Response.Write(idsuc);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dato = wsr.obtenerDPI(Convert.ToString(Session["Usuario"]));
            dataset1 = wsr.obtenerDatosUs(dato);
            if (dataset1 != null)
            {
                nombre.Text = dataset1.Tables[0].Rows[0][0].ToString();
                apellido.Text = dataset1.Tables[0].Rows[0][1].ToString();
                DPI.Text = dataset1.Tables[0].Rows[0][2].ToString();
                telefono.Text = dataset1.Tables[0].Rows[0][3].ToString();
                nit.Text = dataset1.Tables[0].Rows[0][4].ToString();
                direccion.Text = dataset1.Tables[0].Rows[0][5].ToString();
                txtuser.Text = dataset1.Tables[0].Rows[0][6].ToString();
                txtpass.Text = dataset1.Tables[0].Rows[0][7].ToString();



            }
        }

    }
}
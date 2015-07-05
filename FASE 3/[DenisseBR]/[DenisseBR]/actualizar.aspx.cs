using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Services;
using System.Data;

namespace _DenisseBR_
{
           
    public partial class actualizar : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        private System.Data.DataSet dataset1;
        private long dato;
        private string[] sucursal;
        private string msj;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            sucursal = wsr.Sucursal();
            foreach (string sucur in sucursal)
            {

                dds.Items.Add(sucur);
            }
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
                tarjeta.Text = dataset1.Tables[0].Rows[0][8].ToString();

            }


        }

        protected void regitrarUs_Click(object sender, EventArgs e)
        {


            int idsuc = wsr.ObtenerSucursal(Convert.ToString(dds.SelectedItem));

            int total = wsr.ActualizarDatos(nombre.Text, apellido.Text, Convert.ToInt64(DPI.Text), Convert.ToInt32(telefono.Text), Convert.ToInt32(nit.Text), direccion.Text, txtuser.Text, txtpass.Text, idsuc,Convert.ToInt64(tarjeta.Text));
            if (total == 1)
            {
                nombre.Text = "";
                apellido.Text = "";
                DPI.Text = "";
                telefono.Text = "";
                nit.Text = "";
                direccion.Text = "";
                txtuser.Text = "";
                txtpass.Text = "";
                tarjeta.Text = "";
                msj= "Informacion actualizada exitosamente";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                Response.Redirect("cliente.aspx");

            }
            else
            {
                msj = "No se pudo actualizar la informacion";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            
            
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }


    }
}
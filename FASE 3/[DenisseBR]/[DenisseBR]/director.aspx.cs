using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class director : System.Web.UI.Page
    {
        WSR.Service1SoapClient wsr = new WSR.Service1SoapClient();
        String msj;
        int rol;
        private System.Data.DataSet datasetin;
        private System.Data.DataSet datasetemp;
        private System.Data.DataSet dataseEmp;
        private string[] departamento;
        protected void Page_Load(object sender, EventArgs e)
        {
            userEmp.Text = wsr.obtenerEmp(Convert.ToString(Session["Usuario"]));
            rol = wsr.obtenerDept(Convert.ToString(Session["Usuario"]));
            depto.Text = wsr.nombredept(rol);
            datasetin = wsr.mostrarEmpleado(1,rol);
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
            despedirGV.AutoGenerateColumns = true;
            despedirGV.DataSource = datasetin;
            despedirGV.DataBind();
            //departamentos
            ddd.Items.Clear();
            departamento = wsr.departamentos();
            foreach (string dept in departamento)
            {

                ddd.Items.Add(dept);
            }
            datasetemp = wsr.mostrarEquipo(1, rol);
            generalGV.AutoGenerateColumns = true;
            generalGV.DataSource = datasetemp;
            generalGV.DataBind();
        }

        protected void despedirGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = despedirGV.SelectedRow;
            int res = wsr.despedir(Convert.ToInt32(row.Cells[1].Text));
            if(res==1){
                msj = "Empleado " + row.Cells[2].Text + " " + row.Cells[3].Text + " dado de baja";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                rol = wsr.obtenerDept(Convert.ToString(Session["Usuario"]));
                datasetin = wsr.mostrarEmpleado(1, rol);
                despedirGV.AutoGenerateColumns = true;
                despedirGV.DataSource = datasetin;
                despedirGV.DataBind();
            }
            else
            {
                msj = "Error al dar de baja al empleado";
                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
                rol = wsr.obtenerDept(Convert.ToString(Session["Usuario"]));
                datasetin = wsr.mostrarEmpleado(1, rol);
                despedirGV.AutoGenerateColumns = true;
                despedirGV.DataSource = datasetin;
                despedirGV.DataBind();
            }

        }

        protected void despedir_Click(object sender, EventArgs e)
        {
            pnlcontra.Visible = false;
            pnldespedir.Visible = true;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
        }


        protected void contratacion_Click(object sender, EventArgs e)
        {
            pnlcontra.Visible = true;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = false;
            individual.Visible = false;
        }

        protected void equipo_Click(object sender, EventArgs e)
        {
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = false;
        }

        protected void generalGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            msj = "Error al mostrar datos indivudales del empleado";
           /* rol = wsr.obtenerDept(Convert.ToString(Session["Usuario"]));
            datasetemp = wsr.mostrarEquipo(1, rol);
            generalGV.AutoGenerateColumns = true;
            generalGV.DataSource = datasetemp;
            generalGV.DataBind();*/
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = true;
            
            GridViewRow row = generalGV.SelectedRow;
            int codi = Convert.ToInt32(row.Cells[1].Text);
            dataseEmp = wsr.obtenerDatosEmp(codi);
            
            if (dataseEmp != null)
            {
                cod.Text = dataseEmp.Tables[0].Rows[0][0].ToString();
                nom.Text = dataseEmp.Tables[0].Rows[0][1].ToString();
                ape.Text = dataseEmp.Tables[0].Rows[0][2].ToString();
                tel.Text = dataseEmp.Tables[0].Rows[0][3].ToString();
                sueldo.Text = dataseEmp.Tables[0].Rows[0][4].ToString();
                direc.Text = dataseEmp.Tables[0].Rows[0][5].ToString();
                ddd.SelectedItem.Equals(dataseEmp.Tables[0].Rows[0][7].ToString());
                usuarioEmp.Text = dataseEmp.Tables[0].Rows[0][8].ToString();
                txtpass.Text = dataseEmp.Tables[0].Rows[0][9].ToString();
            }
            else
            {

                Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            }
            nom.ReadOnly = true;
            ape.ReadOnly = true;
            tel.ReadOnly = true;
            sueldo.ReadOnly = true;
            direc.ReadOnly = true;
            usuarioEmp.ReadOnly = true;
            txtpass.ReadOnly = true;
            ddd.Enabled = false;
            cod.ReadOnly = true;

        }

        protected void btnmod_Click(object sender, EventArgs e)
        {
            cod.ReadOnly = true;
            nom.ReadOnly = false;
            ape.ReadOnly = false;
            tel.ReadOnly = false;
            sueldo.ReadOnly = false;
            direc.ReadOnly = false;
            usuarioEmp.ReadOnly = false;
            txtpass.ReadOnly = false;
            btng.Visible = true;
            btng.Enabled = true;
            ddd.Enabled = true;
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;
            individual.Visible = true;
        }

        protected void btng_Click(object sender, EventArgs e)
        {
            msj = "Datos actualizados exitosamente";
            wsr.ActualizarDatosEmp(nom.Text,ape.Text,Convert.ToInt32(tel.Text),Convert.ToSingle(sueldo.Text),direc.Text,Convert.ToInt32(ddd.SelectedIndex+1),usuarioEmp.Text,txtpass.Text,Convert.ToInt32(cod.Text));
            Response.Write("<script language='JavaScript'>window.alert('" + msj + "');</script>");
            individual.Visible = false; 
            pnlcontra.Visible = false;
            pnldespedir.Visible = false;
            ConsultarEquipo.Visible = true;

            datasetemp = wsr.mostrarEquipo(1, rol);
            generalGV.AutoGenerateColumns = true;
            generalGV.DataSource = datasetemp;
            generalGV.DataBind();
        }
    }
}
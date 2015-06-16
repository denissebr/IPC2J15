using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practica1
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio inicio = new inicio();
            inicio.Show();
        }

        private void addC_Click(object sender, EventArgs e)
        {

            ServiceReference1.Service1SoapClient ws = new ServiceReference1.Service1SoapClient();
            if (!id.Text.Equals("") && !nombre.Text.Equals("") && !dpi1.Text.Equals("") && !dir.Text.Equals("") && !tel.Text.Equals(""))
            {

                ws.AgregarCliente(Convert.ToInt32(id.Text), nombre.Text, Convert.ToInt64(dpi1.Text), dir.Text, Convert.ToInt64(tel.Text));
                MessageBox.Show("Se ha agregado a : " + nombre.Text + " exitosamente");
                id.Text = "";
                nombre.Text = "";
                dpi1.Text = "";
                dir.Text = "";
                tel.Text = "";
            }
            else
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
        }

       
    }
}

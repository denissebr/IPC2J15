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
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio inicio = new inicio();
            inicio.Show();
        }

        private void addL_Click(object sender, EventArgs e)
        {

            ServiceReference1.Service1SoapClient ws = new ServiceReference1.Service1SoapClient();
            if (!nombreLibro.Text.Equals("") && !existencia.Text.Equals("") && !paginas.Text.Equals("") && !autor.Text.Equals("") && !tema.Text.Equals(""))
            {

                ws.AgregarLibro(nombreLibro.Text, Convert.ToInt32(existencia.Text), Convert.ToInt32(paginas.Text), autor.Text, tema.Text, Convert.ToInt32(existencia.Text), 0, 0);
                MessageBox.Show("Se ha añadido el libro: " + nombreLibro.Text + " exitosamente");
                nombreLibro.Text = "";
                existencia.Text = "";
                paginas.Text = "";
                autor.Text = "";
                tema.Text = "";
            }
            else
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }

        }
    }
}

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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            agregar frm = new agregar();
            frm.Show();
            this.Hide();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            cliente c = new cliente();
            c.Show();
        }

        private void estado_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

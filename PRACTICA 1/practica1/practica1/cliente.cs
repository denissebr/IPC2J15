﻿using System;
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
            inicio.Activate();
        }

       
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaLanche : Form
    {
        public TelaListaLanche()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ManterCliente tela = new ManterCliente();
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }
    }
}

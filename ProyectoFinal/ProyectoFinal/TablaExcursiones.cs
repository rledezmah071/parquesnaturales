﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class TablaExcursion : Form
    {
        public TablaExcursion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaExcursion_Load(object sender, EventArgs e)
        {

        }

        private void buttonExcursionVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaExcursion_Click(object sender, EventArgs e)
        {
            excComboBoxCodAlojamiento.Text = "";
            excFecha.Clear();
            excHora.Clear();
            excID.Clear();
            excTipoExcursion.Clear();
        }
    }
}

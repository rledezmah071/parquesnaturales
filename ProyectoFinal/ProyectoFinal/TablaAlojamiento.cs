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
    public partial class TablaAlojamiento : Form
    {
        public TablaAlojamiento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLimpiaAlojamiento_Click(object sender, EventArgs e)
        {
            aloCategoria.Clear();
            aloID.Clear();
            aloCapacidad.Clear();
            aloComboBoxParque.Text = "";

        }

        private void buttonGuardaAlojamiento_Click(object sender, EventArgs e)
        {

        }

        private void aloCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void aloCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonActualizarAlojamiento_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminaAlojamiento_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxAlojamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aloID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAlojamientoVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void TablaAlojamiento_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using Daily_Track.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Track.Forms
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // Permitir solo números en el campo de texto
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbID.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                tbID.Text = string.Empty;
            }
            // Limitar el campo de texto a un máximo de 5 caracteres
            if (tbID.Text.Length > 13)
            {
                MessageBox.Show("El ID no puede tener más de 13 caracteres.");
                tbID.Text = tbID.Text.Substring(0, 13);
                tbID.SelectionStart = tbID.Text.Length; 
            }
        }
        
        private void tbPaas_TextChanged(object sender, EventArgs e)
        {
            // Limitar la contraseña a un máximo de 8 caracteres
            if (tbPaas.Text.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres.");
                tbPaas.Text = tbPaas.Text.Substring(0, 8);
                tbPaas.SelectionStart = tbPaas.Text.Length; 
            }
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnInto_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin principalAdmin = new FrmPrincipalAdmin();
            principalAdmin.Show();
            this.Hide();
        }
    }
}

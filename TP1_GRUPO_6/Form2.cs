using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_6
{
    public partial class Ejercicio1 : Form
    {
        Main main;
        public Ejercicio1(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            while (nombre.Contains("  "))
                nombre = nombre.Replace("  ", " ");

            if (nombre.Length > 0)
            {
                nombre = nombre.ToLower();
                nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
            }

            if (nombre != "")
            {
                if (!lsbPersonas.Items.Contains(nombre))
                    lsbPersonas.Items.Add(nombre);
                else
                    MessageBox.Show("Nombre repetido.", "Alerta");

                txtNombre.Text = "";
                txtNombre.Focus();
            }
            else
                MessageBox.Show("Ingresar un nombre", "Alerta");
        }

        private void btnPasarValor_Click(object sender, EventArgs e)
        {
            if (lsbPersonas.SelectedItem != null)
            {
                lsbResultado.Items.Add(lsbPersonas.SelectedItem);
                lsbPersonas.Items.Remove(lsbPersonas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccionar un nombre", "Alerta");
            }
        }

        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            if (lsbPersonas.Items.Count > 0)
            {
                foreach (var item in lsbPersonas.Items)
                {
                    lsbResultado.Items.Add(item);
                }

                lsbPersonas.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nombres para transferir");
            }
        }

        private void tbnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar<48 || e.KeyChar>59) && e.KeyChar!=8)
            {
                e.Handled = true;
            }

        }
    }
}

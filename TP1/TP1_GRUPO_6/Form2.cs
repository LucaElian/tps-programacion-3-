using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void tbnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!main.ValidarCampo(txtNombre))
            {
                MessageBox.Show("Ingresar un nombre", "Alerta");
                return;
            }

            string nombre = main.NormalizarNombre(txtNombre.Text);

            if (!lsbPersonas.Items.Contains(nombre))
                lsbPersonas.Items.Add(nombre);
            else
                MessageBox.Show("Nombre repetido.", "Alerta");

            txtNombre.Text = "";
            txtNombre.BackColor = System.Drawing.SystemColors.Control;
            txtNombre.Focus();
        }

        private void btnPasarValor_Click(object sender, EventArgs e)
        {
            if (lsbPersonas.SelectedItem != null)
            {
                lsbResultado.Items.Add(lsbPersonas.SelectedItem);
                lsbPersonas.Items.Remove(lsbPersonas.SelectedItem);
            }
            else
                MessageBox.Show("Seleccionar un nombre", "Alerta");
        }

        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            if (lsbPersonas.Items.Count > 0)
            {
                foreach (var item in lsbPersonas.Items)
                    lsbResultado.Items.Add(item);

                lsbPersonas.Items.Clear();
            }
            else
                MessageBox.Show("No hay nombres para transferir", "Alerta");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.SoloLetras(e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            main.QuitarError(txtNombre);
        }
    }
}

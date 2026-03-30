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
    public partial class Ejercicio2 : Form
    {
        Main main;
        public Ejercicio2(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool nombreValido = main.ValidarCampo(txtNombre);
            bool apellidoValido = main.ValidarCampo(txtApellido);

            if (!nombreValido || !apellidoValido)
            {
                MessageBox.Show("Debe completar todos los campos", "Alerta");
                if (!nombreValido)
                    txtNombre.Focus();
                else
                    txtApellido.Focus();

                return;
            }

            string nombre = main.NormalizarNombre(txtNombre.Text);
            string apellido = main.NormalizarNombre(txtApellido.Text);

            string completo = apellido + " " + nombre;

            if (!lsbElementos.Items.Contains(completo))
                lsbElementos.Items.Add(completo);
            else
                MessageBox.Show("El nombre y apellido ya se encuentra en la lista.", "Alerta");

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lsbElementos.SelectedItem != null)
                lsbElementos.Items.Remove(lsbElementos.SelectedItem);
            else
                MessageBox.Show("Debe seleccionar un elemento para borrar.", "Alerta");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            main.QuitarError(txtNombre);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            main.QuitarError(txtApellido);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.SoloLetras(e);
        }
    }
}


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

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre.Length > 0)
                nombre = char.ToUpper(nombre[0]) + nombre.Substring(1).ToLower();

            if (nombre != "")
            {
                if (!lsbPersonas.Items.Contains(nombre))
                {
                    lsbPersonas.Items.Add(nombre);
                }
                else
                {
                    MessageBox.Show("Nombre repetido.", "Alerta");
                }
            }
            else
                MessageBox.Show("Ingresar un nombre", "Alerta");
        }
    }
}

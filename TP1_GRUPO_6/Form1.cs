using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string NormalizarNombre(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = texto.Trim();

            while (texto.Contains("  "))
                texto = texto.Replace("  ", " ");

            texto = texto.ToLower();
            texto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);

            return texto;
        }

        public bool ValidarCampo(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }

            else
            {
                txt.BackColor = System.Drawing.SystemColors.Control;
                return true;
            }
        }

        public void QuitarError(TextBox txt)
        {
            if (txt.BackColor == Color.Red)
                txt.BackColor = System.Drawing.SystemColors.Control;
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Alerta");
            }
        }


        private void btnEJ1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1(this);
            ejercicio1.Show();
            this.Hide();
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2(this);
            ejercicio2.Show();
            this.Hide();
        }

        private void btnEj3_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3(this);
            ejercicio3.Show();
            this.Hide();
        }
    }
}

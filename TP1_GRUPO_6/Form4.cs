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
    public partial class Ejercicio3 : Form
    {
        Main main;
        public Ejercicio3(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (clbOficios.CheckedItems.Count == 0) 
            {
                lblResultado.Visible = false;
                MessageBox.Show("Debe seleccionar al menos un oficio.", "Alerta");
                return;
            }

            string sexo = rdbFemenino.Checked ? "Femenino" : "Masculino";
            string estadoCivil = rdbCasado.Checked ? "Casado" : "Soltero";
            string oficios = "";

            foreach (var item in clbOficios.CheckedItems)
                oficios += "      - " + item.ToString() + "\n";

            string resultado = "Usted selecciono los siguientes elementos:\n";
            resultado += "Sexo: " + sexo + "\n";
            resultado += "Estado civil: " + estadoCivil + "\n";
            resultado += "Oficio/s:\n" + oficios;
            
            lblResultado.Text = resultado;
            lblResultado.Visible = true;
        }
    }
}

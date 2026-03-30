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

        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string sexo = rdbFemenino.Checked ? "Femenino" : "Masculino";
            string estadoCivil = rdbCasado.Checked ? "Casado" : "Soltero";
            string oficios = "";
            if (cListBoxOficios.SelectedItem != null)
            {
                foreach (var item in cListBoxOficios.CheckedItems)
                {
                    oficios += "\n      - " + item.ToString();
                }

                lblResultado.Text = "Usted seleccionó los siguientes elementos: " + "\nSexo: " + sexo + "\nEstado civil: " + estadoCivil + "\nOficio/s: " + oficios;

            }
            else
            {
                MessageBox.Show("Debe de seleccionar al menos 1 oficio.");
            }
        }
        
    }
}

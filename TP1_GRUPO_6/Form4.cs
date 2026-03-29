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
            string Sexo = "";
            if (rdbFemenino.Checked)
            {
                Sexo = "Femenino";
            }
            else if (rdbMasculino.Checked)
            {
                Sexo = "Masculino";
            }
            
        }
    }
}

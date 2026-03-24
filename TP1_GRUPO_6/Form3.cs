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
            this.main = new Main();
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }
    }
}

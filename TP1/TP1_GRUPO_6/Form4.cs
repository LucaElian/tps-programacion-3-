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

            bool marcado = clbOficios.CheckedItems.Contains("Otro");

            string texto = main.NormalizarNombre(txtOtro.Text);

            if (marcado)
            {
                if (string.IsNullOrWhiteSpace(txtOtro.Text))
                {
                    lblResultado.Visible = false;
                    txtOtro.Focus();
                    txtOtro.BackColor = Color.Red;
                    MessageBox.Show("Debe completar el texto 'Otro'", "Alerta");
                    return;
                }

                foreach (var item in clbOficios.Items)
                {
                    string oficio = main.NormalizarNombre(item.ToString());

                    if (oficio != "Otro" && texto == oficio)
                    {
                        lblResultado.Visible = false;
                        txtOtro.Text = "";
                        txtOtro.Focus();
                        txtOtro.BackColor = Color.Red;
                        MessageBox.Show("El oficio ingresado en 'Otro' ya existe");
                        return;
                    }
                }
            }

            string sexo = rdbFemenino.Checked ? "Femenino" : "Masculino";
            string estadoCivil = rdbCasado.Checked ? "Casado" : "Soltero";
            string oficios = "";

            foreach (var item in clbOficios.CheckedItems) 
            {
                if (item.ToString() != "Otro")
                    oficios += "      - " + item.ToString() + "\n";
                else
                    oficios += "      - " + char.ToUpper(texto.Trim()[0]) + texto.Trim().Substring(1).ToLower();
            }

            string resultado = "Usted selecciono los siguientes elementos:\n";
            resultado += "Sexo: " + sexo + "\n";
            resultado += "Estado civil: " + estadoCivil + "\n";
            resultado += "Oficio/s:\n" + oficios;
            
            lblResultado.Text = resultado;
            lblResultado.Visible = true;
        }

        private void clbOficios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = clbOficios.Items[e.Index].ToString();

            if (item == "Otro")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    lblOtro.Visible = true;
                    txtOtro.Visible = true;
                    txtOtro.Focus();
                }
                else
                {
                    txtOtro.Clear();
                    lblOtro.Visible = false;
                    txtOtro.Visible = false;
                }
            }
        }

        private void txtOtro_TextChanged(object sender, EventArgs e)
        {
            main.QuitarError(txtOtro);
        }
    }
}
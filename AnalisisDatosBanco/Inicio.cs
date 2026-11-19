using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisDatosBanco
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox2023Hipotecario.Text = "";
            textBox2024Hipotecario.Text = "";
            textBox2025Hipotecario.Text = "";
            textBox2023Provincia.Text = "";
            textBox2024Provincia.Text = "";
            textBox2025Provincia.Text = "";
            textBox2023Nacion.Text = "";
            textBox2024Nacion.Text = "";
            textBox2025Nacion.Text = "";
            textBoxPromedioHipotecario.Text = "";
            textBoxPromedioNacion.Text = "";
            textBoxPromedioProvincia.Text = "";
        }
        private bool analizar()
        {
            if (textOk(textBox2023Hipotecario) == true && textOk(textBox2024Hipotecario) == true && textOk(textBox2025Hipotecario) == true && textOk(textBox2023Provincia) == true && textOk(textBox2024Provincia) == true && textOk(textBox2025Provincia) == true && textOk(textBox2023Nacion) == true && textOk(textBox2024Nacion) == true && textOk(textBox2025Nacion) == true)
            {
                textBoxPromedioHipotecario.Text = ((decimal.Parse(textBox2023Hipotecario.Text) + decimal.Parse(textBox2024Hipotecario.Text) + decimal.Parse(textBox2025Hipotecario.Text)) / 3).ToString();
                textBoxPromedioNacion.Text = ((decimal.Parse(textBox2023Nacion.Text) + decimal.Parse(textBox2024Nacion.Text) + decimal.Parse(textBox2025Nacion.Text)) / 3).ToString();
                textBoxPromedioProvincia.Text = ((decimal.Parse(textBox2023Provincia.Text) + decimal.Parse(textBox2024Provincia.Text) + decimal.Parse(textBox2025Provincia.Text)) / 3).ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool textOk(TextBox txtBox)
        {
            return !string.IsNullOrWhiteSpace(txtBox.Text) && decimal.TryParse(txtBox.Text, out _);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (analizar() == true)
            {
                Capital formCapital = new Capital(textBoxPromedioHipotecario.Text, textBoxPromedioNacion.Text, textBoxPromedioProvincia.Text);

                formCapital.StartPosition = FormStartPosition.CenterScreen;

                formCapital.ShowDialog();
            }
        }
    }
}


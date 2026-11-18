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
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //if (textBox2023Hipotecario )
        }

        private bool textOk(TextBox txtBox)
        {
            return !string.IsNullOrWhiteSpace(txtBox.Text) && decimal.TryParse(txtBox.Text, out _);
        }
    }
}


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
    public partial class Capital : Form
    {
        string txtHipotecario;
        string txtNacion;
        string txtProvincia;
        public Capital(string txtBoxHipotecario, string txtBoxNacion, string txtBoxProvincia)
        {
            InitializeComponent();
            txtHipotecario = txtBoxHipotecario;
            txtNacion = txtBoxNacion;
            txtProvincia = txtBoxProvincia;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxCapital.Text) || !decimal.TryParse(textBoxCapital.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el capital a invertir.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Inversion formInversion = new Inversion(textBoxCapital.Text, txtHipotecario, txtProvincia, txtNacion);
            formInversion.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCapital.Text = "";
        }
    }
}

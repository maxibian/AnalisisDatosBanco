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
        public Capital()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxCapital.Text) || !decimal.TryParse(textBoxCapital.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el capital a invertir.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form Inversion = new Inversion();
            Inversion.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCapital.Text = "";
        }
    }
}

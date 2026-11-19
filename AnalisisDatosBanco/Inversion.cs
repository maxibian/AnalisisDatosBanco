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
    public partial class Inversion : Form
    {
        string txtCapital;
        string txtHipotecario;
        string txtProvincia;
        string txtNacion;
        public Inversion(string txtCapital,string txtHipotecario,string txtProvincia,string txtNacion)
        {
            InitializeComponent();
            this.txtCapital = txtCapital;
            this.txtHipotecario = txtHipotecario;
            this.txtProvincia = txtProvincia;
            this.txtNacion = txtNacion;
            
            textBoxMensualHipotecario.Text = mensual(decimal.Parse(txtCapital), decimal.Parse(txtHipotecario));
            textBoxTrimestralHipotecario.Text = trimestral(decimal.Parse(txtCapital), decimal.Parse(txtHipotecario));
            textBoxAnualHipotecario.Text = anual(decimal.Parse(txtCapital), decimal.Parse(txtHipotecario));
            textBoxMensualProvincia.Text = mensual(decimal.Parse(txtCapital), decimal.Parse(txtProvincia));
            textBoxTrimestralProvincia.Text = trimestral(decimal.Parse(txtCapital), decimal.Parse(txtProvincia));
            textBoxAnualProvincia.Text = anual(decimal.Parse(txtCapital), decimal.Parse(txtProvincia));
            textBoxMensualNacion.Text = mensual(decimal.Parse(txtCapital), decimal.Parse(txtNacion));
            textBoxTrimestralNacion.Text = trimestral(decimal.Parse(txtCapital), decimal.Parse(txtNacion));
            textBoxAnualNacion.Text = anual(decimal.Parse(txtCapital), decimal.Parse(txtNacion));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string mensual(decimal capital, decimal tasa)
        {
            decimal pagoAnual = capital;
            decimal interesMensual = (tasa/100) / 12;

            for (int i = 1; i <= 12; i++)
            {
                pagoAnual = pagoAnual + (pagoAnual * interesMensual);
                
            }
            pagoAnual = pagoAnual - capital;
            return pagoAnual.ToString("F2");
        }
        private string trimestral(decimal capital, decimal tasa)
        {
            decimal pagoAnual = capital;
            decimal interesTrimestral = (tasa/100) / 4;

            for (int i = 1; i <= 4; i++)
            {
                pagoAnual = pagoAnual + (pagoAnual * interesTrimestral);
            }
            pagoAnual = pagoAnual - capital;
            return pagoAnual.ToString("F2");
        }
        private string anual(decimal capital, decimal tasa)
        {
            tasa = tasa / 100;
            decimal pagoAnual = (capital * tasa) + capital;
            pagoAnual = pagoAnual - capital;
            return pagoAnual.ToString("F2");
        }
    }
}

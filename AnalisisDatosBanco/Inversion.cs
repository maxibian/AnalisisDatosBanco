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
        public Inversion(string txtCapital, string txtHipotecario, string txtProvincia, string txtNacion)
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

            MejorOpcion(decimal.Parse(textBoxAnualHipotecario.Text), decimal.Parse(textBoxAnualProvincia.Text), decimal.Parse(textBoxAnualNacion.Text));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string mensual(decimal capital, decimal tasa)
        {
            decimal pagoAnual = capital;
            decimal interesMensual = (tasa / 100) / 12;

            for (int i = 1; i <= 12; i++)
            {
                pagoAnual = pagoAnual + (pagoAnual * interesMensual);

            }
            pagoAnual = pagoAnual - capital;
            return pagoAnual.ToString("F4");
        }
        private string trimestral(decimal capital, decimal tasa)
        {
            decimal pagoAnual = capital;
            decimal interesTrimestral = (tasa / 100) / 4;

            for (int i = 1; i <= 4; i++)
            {
                pagoAnual = pagoAnual + (pagoAnual * interesTrimestral);
            }
            pagoAnual = pagoAnual - capital;
            return pagoAnual.ToString("F4");
        }
        private string anual(decimal capital, decimal tasa)
        {
            tasa = tasa / 100;
            decimal pagoAnual = (capital * tasa) + capital;
            pagoAnual = pagoAnual - capital;
            return pagoAnual.ToString("F4");
        }
        public void MejorOpcion(decimal txt1, decimal txt2, decimal txt3)
        {
            if (txt1 > txt2 && txt1 > txt3)
            {
                textBoxOpcionHipotecario.BackColor = Color.Green;
                textBoxOpcionHipotecario.Text = "Mejor Opción";
                textBoxOpcionNacion.BackColor = Color.Firebrick;
                textBoxOpcionProvincia.BackColor = Color.Firebrick;
            }
            else if (txt2 > txt1 && txt2 > txt3)
            {
                textBoxOpcionProvincia.BackColor = Color.Green;
                textBoxOpcionProvincia.Text = "Mejor Opción";
                textBoxOpcionHipotecario.BackColor = Color.Firebrick;
                textBoxOpcionNacion.BackColor = Color.Firebrick;
            }

            else if (txt3 > txt1 && txt3 > txt2)
            {
                textBoxOpcionNacion.BackColor = Color.Green;
                textBoxOpcionNacion.Text = "Mejor Opción";
                textBoxOpcionHipotecario.BackColor = Color.Firebrick;
                textBoxOpcionProvincia.BackColor = Color.Firebrick  ;
            }
            else if (txt1 == txt2 && txt2 == txt3)
            {
                textBoxOpcionHipotecario.BackColor = Color.Green;
                textBoxOpcionHipotecario.Text = "Mejor Opción";
                textBoxOpcionProvincia.BackColor = Color.Green;
                textBoxOpcionProvincia.Text = "Mejor Opción";
                textBoxOpcionNacion.BackColor = Color.Green ;
                textBoxOpcionNacion.Text = "Mejor Opción";
            }
            else if (txt1 == txt2)
            {
                textBoxOpcionHipotecario.BackColor = Color.Green;
                textBoxOpcionHipotecario.Text = "Mejor Opción";
                textBoxOpcionProvincia.BackColor = Color.Green;
                textBoxOpcionProvincia.Text = "Mejor Opción";
                textBoxOpcionNacion.BackColor = Color.Firebrick;
            }
            else if (txt2 == txt3)
            {
                textBoxOpcionProvincia.BackColor = Color.Green;
                textBoxOpcionProvincia.Text = "Mejor Opción";
                textBoxOpcionNacion.BackColor = Color.Green;
                textBoxOpcionNacion.Text = "Mejor Opción";
                textBoxOpcionHipotecario.BackColor = Color.Firebrick;
            }
            else if (txt1 == txt3)
            {
                textBoxOpcionHipotecario.BackColor = Color.Green;
                textBoxOpcionHipotecario.Text = "Mejor Opción";
                textBoxOpcionNacion.BackColor = Color.Green;
                textBoxOpcionNacion.Text = "Mejor Opción";
                textBoxOpcionProvincia.BackColor = Color.Firebrick;
            }
        }
    }
}

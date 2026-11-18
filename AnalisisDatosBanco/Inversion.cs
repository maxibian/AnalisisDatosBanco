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


            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string mensual(decimal capital, decimal tasa)
        {
            decimal interesMensual = tasa / 12;

            for (int i = 1; i < 12; i++)
            {
                capital = capital + (capital * interesMensual);
            }
            return capital.ToString("F2");
        }
        private string trimestral(decimal capital, decimal tasa)
        {
            decimal interesTrimestral = tasa / 4;

            for (int i = 1; i < 4; i++)
            {
                capital = capital + (capital * interesTrimestral);
            } 
            return capital.ToString("F2");
        }
        private string anual(decimal capital, decimal tasa)
        {
            decimal pagoAnual = (capital * tasa) + capital;
            return pagoAnual.ToString("F2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUESTAO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularConsumo_Click(object sender, EventArgs e)
        {
            //Declaração de variaveis

            int LeituraAnterior, LeituraAtual;
            double ValorApagar;

            //Entrada de dados

            LeituraAtual = int.Parse(txtConsumoAtual.Text);
            LeituraAnterior = int.Parse(txtmesanterior.Text);

            //Processamento de dados

            ValorApagar = 1.09912881 * (LeituraAtual - LeituraAnterior);

            //Exibir os resultados

            txtEXIBIR.Text = ValorApagar.ToString("C");

        }
    }
}

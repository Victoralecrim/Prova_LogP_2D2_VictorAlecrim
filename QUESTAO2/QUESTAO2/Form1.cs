using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUESTAO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcArea_Click(object sender, EventArgs e)
        {
            //Declaração de variaveis

            double Base1, Altura1, Base2, Altura2, Area1, Area2;

            //Entrada de dados

            Base1 = double.Parse(txtbase.Text);
            Altura1 = double.Parse(txtAltura.Text);
            

            Base2 = double.Parse(txtBase2.Text);
            Altura2 = double.Parse(txtAltura2.Text);

            Area1 = (Base1 * Altura1) / 2;
            txtArea1.Text = Area1.ToString();
            Area2 = (Base2 * Altura2) / 2;
            txtArea2.Text = Area2.ToString();

            if (Area1 > Area2)
            {
                MessageBox.Show("A area do triangulo 1 é maior");
            }

            else if (Area2 > Area1)
            {
                MessageBox.Show("A area do triangulo 2 é maior que a do 1");
            }

            else
            {
                MessageBox.Show("As areas são iguais");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

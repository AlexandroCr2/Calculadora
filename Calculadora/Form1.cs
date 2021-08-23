using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
               txtVisor.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUBTRACAO")
            { 
                txtVisor.Text = Convert.ToString(valor1 - valor2); 
            }
            else if(operacao == "DIVISAO")
            {
                txtVisor.Text = Convert.ToString(valor1 / valor2);
            }
            else 
            { 
                txtVisor.Text = Convert.ToString(valor1 * valor2); 
            }
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "SUBTRACAO";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "MULTIPLICACAO";
            lblOperacao.Text = "X";
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "DIVISAO";
            lblOperacao.Text = "/";
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }
    }
}

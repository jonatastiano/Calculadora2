using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class FormCalculadora : Form
    {
        bool operacao = true;
        string operador;
        double numero1;
        double numero2;
        double resultado;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "1";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "2";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "2";
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "3";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "4";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "5";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "6";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "7";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "8";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "9";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "9";
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                return;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "0";
            }
        }

        private void btAdicao_Click(object sender, EventArgs e)
        {
            operador = "+";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            operador = "-";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            operador = "*";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            //numero1 = Convert.ToDouble(txtResultado.Text);
            numero2 = Convert.ToDouble(txtResultado.Text);
            operacao = true;
            switch (operador)
            {
                case "+":
                    {
                        resultado = numero1 + numero2;
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
                case "-":
                    {
                        resultado = numero1 - numero2;
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
                case "*":
                    {
                        resultado = numero1 * numero2;
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
                case "/":
                    {
                        resultado = numero1 / numero2;
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
            }
        }

        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = ",";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += ",";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text = "";
        }
    }
}

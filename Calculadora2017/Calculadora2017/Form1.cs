using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double resultado = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        #region Botões

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        } 
        #endregion

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(txtDisplay.Text);
            operador = "*";
            txtDisplay.Text = "";
        }
        #region Operadores

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operador == "*")
            {
                resultado *= Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = resultado.ToString();
            }
            else if (operador == "/")
            {
                resultado /= Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = resultado.ToString();
            }
            else if (operador == "+")
            {
                resultado += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = resultado.ToString();
            }
            else if (operador == "-")
            {
                resultado -= Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = resultado.ToString();
            }
            else if (operador == "a")
            {

                double pot;
                double res = Convert.ToDouble(txtDisplay.Text);
                pot = Math.Pow(resultado, res);
                txtDisplay.Text = pot.ToString();
            }

        } 
        #endregion

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            resultado = 0;
            operador = "";
            txtDisplay.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(txtDisplay.Text);
            operador = "/";
            txtDisplay.Text = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != ",")
            {
                txtDisplay.Text += ",";
            }
            else
            {
                txtDisplay.Text = "";
                    
            }
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            resultado += Convert.ToDouble(txtDisplay.Text);
            operador = "+";
            txtDisplay.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(txtDisplay.Text);
            operador = "-";
            txtDisplay.Text = "";
              
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double rest;
            resultado = Convert.ToDouble(txtDisplay.Text);

            rest = Math.Sqrt(resultado);
         
            txtDisplay.Text = rest.ToString();
                         
            
            
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

            if (operador == "*")
            {
                double mult;

                mult = resultado / 100 * Convert.ToDouble(txtDisplay.Text);

                txtDisplay.Text = mult.ToString();
            }
            else if (operador == "/")
            {
                double div;

                div = resultado / 100 * Convert.ToDouble(txtDisplay.Text);

                txtDisplay.Text = div.ToString();
            }
            else if (operador == "+")
            {
                double soma;
              
                soma = resultado / 100 * Convert.ToDouble(txtDisplay.Text) + resultado;

                txtDisplay.Text = soma.ToString();
            }
            else if (operador == "-")
            {
                double subtracao;
                subtracao = resultado / 100 * Convert.ToDouble(txtDisplay.Text);                
                txtDisplay.Text = subtracao.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            resultado = Convert.ToDouble(txtDisplay.Text);
            operador = "a";
            txtDisplay.Text = "";

            

        }
    }
}

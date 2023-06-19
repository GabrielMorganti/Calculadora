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

namespace Calculadora {
    public partial class Calculadora : Form {

        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Calculadora() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button17_Click(object sender, EventArgs e) {
            //Concatenando o número 0
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e) {
            //Concatenando o número 1
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button19_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e) {

            if(TxtResultado.Text != "") { 
            //Aqui pegamos o valor1 e armazenar o texto do TxtResultado 
            //dentro dela

            valor1 = decimal.Parse(TxtResultado.Text,CultureInfo.InvariantCulture);

            //Limpando o TxtResultado
            TxtResultado.Text = "";

            //Informando ao programa que é um soma
            operacao = "SOMA";

            //Informando ao usuário a operação que estamos usando
            labelOperacao.Text = $"{valor1} +";

            }
        }

        private void button11_Click(object sender, EventArgs e) {
             
            if(TxtResultado.Text != "") {
                //Pegando o valor2
                valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
 
            //Verificando qual é a operação matematica
             if(operacao == "SOMA") {
                //Mostrando o resultado
                //A calculadora está recebendo uma string 
                //por isso convertemos para string
                TxtResultado.Text = Convert.ToString(valor1 + valor2);
                labelOperacao.Text = "";
            } 
            else if (operacao == "SUB") {

                TxtResultado.Text = Convert.ToString(valor1 - valor2);
                labelOperacao.Text = "";

            }
            else if (operacao == "MULTI") {

                TxtResultado.Text = Convert.ToString(valor1 * valor2);
                labelOperacao.Text = "";

            }
            else if (operacao == "DIV") {

                TxtResultado.Text = Convert.ToString(valor1 / valor2);
                labelOperacao.Text = "";

                }
            }
        }

        private void Calculadora_Load(object sender, EventArgs e) {

        }

        private void button8_Click(object sender, EventArgs e) {

            if(TxtResultado.Text != "") {

            
            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            //Limpando o TxtResultado
            TxtResultado.Text = "";

            //Informando ao programa que é um soma
            operacao = "SUB";

            //Informando ao usuário a operação que estamos usando
            labelOperacao.Text = $"{valor1} -";
            }
        }

        private void button13_Click(object sender, EventArgs e) {

            if(TxtResultado.Text != "") { 

            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            //Limpando o TxtResultado
            TxtResultado.Text = "";

            //Informando ao programa que é um soma
            operacao = "MULTI";

            //Informando ao usuário a operação que estamos usando
            labelOperacao.Text = $"{valor1} *";
            }
        }

        private void button18_Click(object sender, EventArgs e) {

            if(TxtResultado.Text != "") { 

            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            //Limpando o TxtResultado
            TxtResultado.Text = "";

            //Informando ao programa que é um soma
            operacao = "DIV";

            //Informando ao usuário a operação que estamos usando
            labelOperacao.Text = $"{valor1} /";
            }

        }

        private void button5_Click(object sender, EventArgs e) {
            TxtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) {
            TxtResultado.Text = "";
            labelOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }
    }
}

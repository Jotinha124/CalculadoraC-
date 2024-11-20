using System.Diagnostics;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void button_menos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void button_vezes_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void button_dividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Resultado.ToString();
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
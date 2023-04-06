namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }
        private operacao OperacaoSelecionada { get; set; }
        private enum operacao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
            txt_operacao.Text += "0";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
            txt_operacao.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
            txt_operacao.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
            txt_operacao.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
            txt_operacao.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
            txt_operacao.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
            txt_operacao.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
            txt_operacao.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
            txt_operacao.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
            txt_operacao.Text += "9";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.subtracao;
            lb_operacao.Text = "-";
            valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            txt_operacao.Text += " - ";
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.adicao;
            lb_operacao.Text = "+";
            valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            txt_operacao.Text += " + ";
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.multiplicacao;
            lb_operacao.Text = "*";
            valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            txt_operacao.Text += " * ";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.divisao;
            lb_operacao.Text = "/";
            valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
            txt_operacao.Text += " / ";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case operacao.adicao:
                    resultado = valor + Convert.ToDecimal(txt_resultado.Text);
                    break;
                case operacao.subtracao:
                    resultado = valor - Convert.ToDecimal(txt_resultado.Text);
                    break;
                case operacao.multiplicacao:
                    resultado = valor * Convert.ToDecimal(txt_resultado.Text);
                    break;
                case operacao.divisao:
                    resultado = valor / Convert.ToDecimal(txt_resultado.Text);
                    break;
            }
            txt_resultado.Text = Convert.ToString(resultado);
            lb_operacao.Text = "=";
        }



        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            lb_operacao.Text = "";
            txt_operacao.Text = "";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (!txt_resultado.Text.Contains(","))
                txt_resultado.Text += ",";
        }
    }
}
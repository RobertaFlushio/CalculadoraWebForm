namespace desenvolvimentoDesktop
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            string valorA = txtValorA.Text;
            string valorB = txtValorB.Text;

            double a = Convert.ToDouble(valorA);
            double b = Convert.ToDouble(valorB);

            double somar = a + b;

            string resposta = "O resultado da soma è: " + somar;

            MessageBox.Show(resposta);
            lblResposta.Text = resposta;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string valorA = txtValorA.Text;
            string valorB = txtValorB.Text;

            double a = Convert.ToDouble(valorA);
            double b = Convert.ToDouble(valorB);

            double dividir = a / b;

            string resposta = "O resultado da soma è: " + dividir;

            MessageBox.Show(resposta);
            lblResposta.Text = resposta;
        }

        private void b_Click(object sender, EventArgs e)
        {
            string valorA = txtValorA.Text;
            string valorB = txtValorB.Text;

            double a = Convert.ToDouble(valorA);
            double b = Convert.ToDouble(valorB);

            double somar = a + b;

            string resposta = "O resultado da soma è: " + somar;

            MessageBox.Show(resposta);
            lblResposta.Text = resposta;
        }

        private void b_Click_1(object sender, EventArgs e)
        {
            string valorA = txtValorA.Text;
            string valorB = txtValorB.Text;

            double a = Convert.ToDouble(valorA);
            double b = Convert.ToDouble(valorB);

            double dividir = a / b;

            string resposta = "O resultado da soma è: " + dividir;

            MessageBox.Show(resposta);
            lblResposta.Text = resposta;
        }
    }
}


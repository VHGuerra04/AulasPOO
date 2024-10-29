using System.Configuration;

namespace ContaBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Instância da classe
            Cliente objCliente = new Cliente(txbCPF.Text);
            //Cliente objCliente = new Cliente(txbCPF.Text, txbNome.Text);

            objCliente.Codigo = int.Parse(txbCodigoCliente.Text);
            //objCliente.CPF = txbCPF.Text;
            objCliente.Nome = txbNome.Text;
            objCliente.Endereco = txbEndereco.Text;
            objCliente.Idade = int.Parse(txbIdade.Text);

            if (objCliente.MaiorDeIdade(18))
                MessageBox.Show("Cliente é maior de idade");
            else
                MessageBox.Show("Cliente é menor de idade");


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            try //tratamento de erro/excessão
            {
                Cliente objCliente = new Cliente(txbCPF.Text, txbNome.Text);
                Conta objConta = new Conta();

                objConta.Agencia = txbAgencia.Text;
                objConta.Numero = int.Parse(txbNumeroConta.Text);
                objConta.Titular = objCliente;

                MessageBox.Show("Saldo da conta: " + objConta.Saldo,
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                objConta.Depositar(15);

                MessageBox.Show("Novo saldo da conta: " + objConta.Saldo,
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bool SucessoSaque = objConta.Sacar(200);

                if (SucessoSaque)
                {
                    MessageBox.Show("Novo saldo da conta: " + objConta.Saldo,
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Informe todos os campos da conta", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaPoupanca objContaPoupanca = new ContaPoupanca();
            objContaPoupanca.Agencia = txbAgencia.Text;
            objContaPoupanca.Numero = int.Parse(txbNumeroConta.Text);

            objContaPoupanca.Depositar(200);
        }
    }
}

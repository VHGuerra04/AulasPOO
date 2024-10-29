namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int primeiroNumero = int.Parse(txbprimeironumero.Text);
            int segundoNumero = int.Parse(txbsegundonumero.Text);

            txbresultado.Text = somar(primeiroNumero, segundoNumero). ToString();

            /*
            int resultado = primeiroNumero + segundoNumero;
                   

            txbresultado.Text = resultado.ToString();

            MessageBox.Show("Soma realizada com sucesso!"); */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int primeiroNumero = int.Parse(txbprimeironumero.Text);
            int segundoNumero = int.Parse(txbsegundonumero.Text);

            int resultado = primeiroNumero - segundoNumero;


            txbresultado.Text = resultado.ToString();

            MessageBox.Show("Subtração realizada com sucesso!");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            int primeiroNumero = int.Parse(txbprimeironumero.Text);
            int segundoNumero = int.Parse(txbsegundonumero.Text);

            int resultado = primeiroNumero * segundoNumero;


            txbresultado.Text = resultado.ToString();

            MessageBox.Show("Multiplicação realizada com sucesso!");
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            int primeiroNumero = int.Parse(txbprimeironumero.Text);
            int segundoNumero = int.Parse(txbsegundonumero.Text);

            int resultado = primeiroNumero / segundoNumero;


            txbresultado.Text = resultado.ToString();

            MessageBox.Show("Divisão realizada com sucesso!");
        }

        //void não retorna valor, apenas executa o codigo

        private int somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private int somar2()
        {
            int primeiroNumero = int.Parse(txbprimeironumero.Text);
            int segundoNumero = int.Parse(txbsegundonumero.Text);

            return primeiroNumero + segundoNumero;
        }
    }
}

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscaNome_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.codigo_pessoa = 1;
            objPessoa.nome = "Guerra";
            objPessoa.CPF = "02397833005";
            objPessoa.Genero = "M";
            objPessoa.Endereco = "Centro";
            objPessoa.Cidade = "Três de Maio";

            string NomePessoa = objPessoa.BuscarNome(objPessoa);

            MessageBox.Show("Nome da pessoa " + NomePessoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item objItem = new Item();
            objItem.codigo_item = 2;
            objItem.descricao = "Jurassic Park";
            objItem.autor = "Michael Crichton";
            objItem.ano = 1990;
            objItem.editora = "aleph";
            objItem.edicao = 1;
            objItem.idioma = 1;
            objItem.tipo = 1;
            objItem.situacao = "Disponível";



            string NomeItem = objItem.BuscarNome(objItem);

            MessageBox.Show("Nome do item " + NomeItem);
        }
    }
}

using ControleVendas.dao;
using ControleVendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.view
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            fornecedor objFornecedor = new fornecedor();
            objFornecedor.Nome = txbnome.Text;
            objFornecedor.cnpj = txbcnpj.Text;
            objFornecedor.Email = txbemail.Text;
            objFornecedor.Telefone = txbtelefone.Text;
            objFornecedor.Celular = txbcelular.Text;
            objFornecedor.CEP = txbcep.Text;
            objFornecedor.Endereco = txbendereco.Text;
            objFornecedor.Numero = int.Parse(txbnumero.Text);
            objFornecedor.Comlemento = txbcomlemento.Text;
            objFornecedor.Bairro = txbbairro.Text;
            objFornecedor.Cidade = txbcidade.Text;
            objFornecedor.Estado = cbestado.Text;

            FornecedorDAO dao = new FornecedorDAO();
            if (dao.CadastrarFornecedor(objFornecedor))
                MessageBox.Show("Fornecedor Cadastrado.");

            dgvFornecedores.DataSource = dao.ListarFornecedores();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            dgvFornecedores.DataSource = dao.ListarFornecedores();
        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txbpesquisar.Text + "%";
            FornecedorDAO dao = new FornecedorDAO();

            dgvFornecedores.DataSource = dao.PesquisarFornecedorPorNome(nome);
        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            fornecedor objFornecedor = new fornecedor();
            objFornecedor.Nome = txbnome.Text;
            objFornecedor.cnpj = txbcnpj.Text;
            objFornecedor.Email = txbemail.Text;
            objFornecedor.Telefone = txbtelefone.Text;
            objFornecedor.Celular = txbcelular.Text;
            objFornecedor.CEP = txbcep.Text;
            objFornecedor.Endereco = txbendereco.Text;
            objFornecedor.Numero = int.Parse(txbnumero.Text);
            objFornecedor.Comlemento = txbcomlemento.Text;
            objFornecedor.Bairro = txbbairro.Text;
            objFornecedor.Cidade = txbcidade.Text;
            objFornecedor.Estado = cbestado.Text;
            objFornecedor.id = int.Parse(txbcodigo.Text);


            FornecedorDAO dao = new FornecedorDAO();
            if (dao.AlterarFornecedor(objFornecedor))
            {
                MessageBox.Show("Fornecedor Alterado.");
            }

            dgvFornecedores.DataSource = dao.ListarFornecedores();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o fornecedor???",
    "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                fornecedor objFornecedor = new fornecedor();
                objFornecedor.id = int.Parse(txbcodigo.Text);

                FornecedorDAO dao = new FornecedorDAO();
                if (dao.ExcluirFornecedor(objFornecedor))
                    MessageBox.Show("Fornecedor Excluido!");

                dgvFornecedores.DataSource = dao.ListarFornecedores();

            }
        }

        private void txbcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbcodigo.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            txbnome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            txbcnpj.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
            txbemail.Text = dgvFornecedores.CurrentRow.Cells[3].Value.ToString();
            txbtelefone.Text = dgvFornecedores.CurrentRow.Cells[4].Value.ToString();
            txbcelular.Text = dgvFornecedores.CurrentRow.Cells[5].Value.ToString();
            txbcep.Text = dgvFornecedores.CurrentRow.Cells[6].Value.ToString();
            txbendereco.Text = dgvFornecedores.CurrentRow.Cells[7].Value.ToString();
            txbnumero.Text = dgvFornecedores.CurrentRow.Cells[8].Value.ToString();
            txbcomlemento.Text = dgvFornecedores.CurrentRow.Cells[9].Value.ToString();
            txbbairro.Text = dgvFornecedores.CurrentRow.Cells[10].Value.ToString();
            txbcidade.Text = dgvFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbestado.Text = dgvFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
        }
    }
}

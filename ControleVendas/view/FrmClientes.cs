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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            cliente objCliente = new cliente();
            objCliente.Nome = txbnome.Text;
            objCliente.RG = txbrg.Text;
            objCliente.CPF = txbcpf.Text;
            objCliente.Email = txbemail.Text;
            objCliente.Telefone = txbtelefone.Text;
            objCliente.Celular = txbcelular.Text;
            objCliente.CEP = txbcep.Text;
            objCliente.Endereco = txbendereco.Text;
            objCliente.Numero = int.Parse(txbnumero.Text);
            objCliente.Comlemento = txbcomlemento.Text;
            objCliente.Bairro = txbbairro.Text;
            objCliente.Cidade = txbcidade.Text;
            objCliente.Estado = cbestado.Text;

            ClienteDAO dao = new ClienteDAO();
            if (dao.CadastrarCliente(objCliente))
                MessageBox.Show("Cliente Cadastrado.");

            dgvclientes.DataSource = dao.ListarClientes();


        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgvclientes.DataSource = dao.ListarClientes();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txbpesquisar.Text + "%";
            ClienteDAO dao = new ClienteDAO();

            dgvclientes.DataSource = dao.PesquisarClientePorNome(nome);


        }

        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbcodigo.Text = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            txbnome.Text = dgvclientes.CurrentRow.Cells[1].Value.ToString();
            txbrg.Text = dgvclientes.CurrentRow.Cells[2].Value.ToString();
            txbcpf.Text = dgvclientes.CurrentRow.Cells[3].Value.ToString();
            txbemail.Text = dgvclientes.CurrentRow.Cells[4].Value.ToString();
            txbtelefone.Text = dgvclientes.CurrentRow.Cells[5].Value.ToString();
            txbcelular.Text = dgvclientes.CurrentRow.Cells[6].Value.ToString();
            txbcep.Text = dgvclientes.CurrentRow.Cells[7].Value.ToString();
            txbendereco.Text = dgvclientes.CurrentRow.Cells[8].Value.ToString();
            txbnumero.Text = dgvclientes.CurrentRow.Cells[9].Value.ToString();
            txbcomlemento.Text = dgvclientes.CurrentRow.Cells[10].Value.ToString();
            txbbairro.Text = dgvclientes.CurrentRow.Cells[11].Value.ToString();
            txbcidade.Text = dgvclientes.CurrentRow.Cells[12].Value.ToString();
            cbestado.Text = dgvclientes.CurrentRow.Cells[13].Value.ToString();

            tabControl1.SelectedTab = tabPage1;

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

            {
                cliente objCliente = new cliente();
                objCliente.Nome = txbnome.Text;
                objCliente.RG = txbrg.Text;
                objCliente.CPF = txbcpf.Text;
                objCliente.Email = txbemail.Text;
                objCliente.Telefone = txbtelefone.Text;
                objCliente.Celular = txbcelular.Text;
                objCliente.CEP = txbcep.Text;
                objCliente.Endereco = txbendereco.Text;
                objCliente.Numero = int.Parse(txbnumero.Text);
                objCliente.Comlemento = txbcomlemento.Text;
                objCliente.Bairro = txbbairro.Text;
                objCliente.Cidade = txbcidade.Text;
                objCliente.Estado = cbestado.Text;
                objCliente.id = int.Parse(txbcodigo.Text);


                ClienteDAO dao = new ClienteDAO();
                if (dao.AlterarCliente(objCliente))
                    MessageBox.Show("Cliente Alterado.");

                dgvclientes.DataSource = dao.ListarClientes();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o cliente???",
                "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cliente objcliente = new cliente();
                objcliente.id = int.Parse(txbcodigo.Text);

                ClienteDAO dao = new ClienteDAO();
                if (dao.ExcluirCliente(objcliente))
                    MessageBox.Show("Cliente Excluido!");

                dgvclientes.DataSource = dao.ListarClientes();

            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

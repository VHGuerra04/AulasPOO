using ControleVendas.conexao;
using ControleVendas.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.dao
{
    internal class ProdutoDAO
    {
        private MySqlConnection conexao;

        //método construtor, principal caracteristica ter o mesmo nome da classe
        public ProdutoDAO()
        {
            this.conexao = new ConexaoBD().GetConnection ();
        }

        public bool CadastrarProduto(Produto objProduto)
        {
            try
            {
                string sql = @"INSERT INTO vendas.produtos
                (id, descricao, preco, qtd_estoque, for_id)
                VALUES(@Descricao, @Preco, @QtdEstoque, @Fornecedor,);";

                MySqlCommand execSql = new MySqlCommand (sql, conexao);

                execSql.Parameters.AddWithValue("@Descricao", objProduto.Descricao);
                execSql.Parameters.AddWithValue("Preco", objProduto.Preco);
                execSql.Parameters.AddWithValue("@QtdEstoque", objProduto.QtdEstoque);
                execSql.Parameters.AddWithValue("@Fornecedor", objProduto.Fornecedor);

                conexao.Open();
                execSql.ExecuteNonQuery();

                return true;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ListarProdutos()
        {

        }



    }
}

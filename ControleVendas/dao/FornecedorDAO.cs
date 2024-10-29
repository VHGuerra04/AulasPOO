using ControleVendas.conexao;
using ControleVendas.model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleVendas.dao
{
        internal class FornecedorDAO
        {
            private MySqlConnection conexao;

            /*método construtor 
             Ivocado toda vez que a classe é instaciada 
             */
            public FornecedorDAO()
            {
                this.conexao = new ConexaoBD().GetConnection();
            }

            public bool CadastrarFornecedor(fornecedor objFornecedor)
            {
                try
                {
                    string sql = @"insert into fornecedores (nome, cnpj, email, telefone, 
                celular, cep, endereco, numero, complemento, bairro, cidade, estado) values(@nome, @cnpj, @email, @telefone, 
                @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                    MySqlCommand execSQL = new MySqlCommand(sql, conexao);
                    execSQL.Parameters.AddWithValue("@nome", objFornecedor.Nome);
                    execSQL.Parameters.AddWithValue("@cnpj", objFornecedor.cnpj);
                    execSQL.Parameters.AddWithValue("@email", objFornecedor.Email);
                    execSQL.Parameters.AddWithValue("@telefone", objFornecedor.Telefone);
                    execSQL.Parameters.AddWithValue("@celular", objFornecedor.Celular);
                    execSQL.Parameters.AddWithValue("@cep", objFornecedor.CEP);
                    execSQL.Parameters.AddWithValue("@endereco", objFornecedor.Endereco);
                    execSQL.Parameters.AddWithValue("@numero", objFornecedor.Numero);
                    execSQL.Parameters.AddWithValue("@complemento", objFornecedor.Comlemento);
                    execSQL.Parameters.AddWithValue("@bairro", objFornecedor.Bairro);
                    execSQL.Parameters.AddWithValue("@cidade", objFornecedor.Cidade);
                    execSQL.Parameters.AddWithValue("@estado", objFornecedor.Estado);

                    conexao.Open();
                    execSQL.ExecuteNonQuery();
                    return true;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro" + erro);
                    return false;
                }

                finally
                {
                    conexao.Close();
                }


            }

            public DataTable ListarFornecedores()
            {
                try
                {
                    DataTable forncedores = new DataTable();
                    string sql = "select * from fornecedores";

                    MySqlCommand execSql = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    execSql.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(execSql);
                    da.Fill(forncedores);

                    return forncedores;

                }
                catch (global::System.Exception erro)
                {
                    MessageBox.Show("Erro" + erro);
                    return null;
                }
                finally
                {
                    conexao.Close();
                }

            }

            public DataTable PesquisarFornecedorPorNome(string nome)
            {
                try
                {
                    DataTable fornecedores = new DataTable();
                    string sql = "select * from fornecedores where nome like @nome";

                    MySqlCommand execSql = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    execSql.Parameters.AddWithValue("@nome", nome);
                    execSql.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(execSql);
                    da.Fill(fornecedores);

                    return fornecedores;

                }
                catch (global::System.Exception erro)
                {
                    MessageBox.Show("Erro" + erro);
                    return null;
                }
                finally
                {
                    conexao.Close();
                }
            }

            public bool AlterarFornecedor(fornecedor objFornecedor)
            {
                try
                {
                string sql = @"UPDATE vendas.fornecedores
                SET nome = @nome, cnpj = @cnpj, email = @email, telefone = @telefone, celular = @celular, 
                cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, 
                cidade = @cidade, estado = @estado WHERE id = @id;";

                MySqlCommand execSQL = new MySqlCommand(sql, conexao);
                execSQL.Parameters.AddWithValue("@nome", objFornecedor.Nome);
                execSQL.Parameters.AddWithValue("@cnpj", objFornecedor.cnpj);
                execSQL.Parameters.AddWithValue("@email", objFornecedor.Email);
                execSQL.Parameters.AddWithValue("@telefone", objFornecedor.Telefone);
                execSQL.Parameters.AddWithValue("@celular", objFornecedor.Celular);
                execSQL.Parameters.AddWithValue("@cep", objFornecedor.CEP);
                execSQL.Parameters.AddWithValue("@endereco", objFornecedor.Endereco);
                execSQL.Parameters.AddWithValue("@numero", objFornecedor.Numero);
                execSQL.Parameters.AddWithValue("@complemento", objFornecedor.Comlemento);
                execSQL.Parameters.AddWithValue("@bairro", objFornecedor.Bairro);
                execSQL.Parameters.AddWithValue("@cidade", objFornecedor.Cidade);
                execSQL.Parameters.AddWithValue("@estado", objFornecedor.Estado);
                execSQL.Parameters.AddWithValue("@id", objFornecedor.id);



                conexao.Open();
                    execSQL.ExecuteNonQuery();
                    return true;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro" + erro);
                    return false;
                }

                finally
                {
                    conexao.Close();
                }
            }

            public bool ExcluirFornecedor(fornecedor objFornecedor)
            {
                try
                {
                    string sql = @"delete from fornecedores where id = @id";

                    MySqlCommand execSQL = new MySqlCommand(sql, conexao);
                    execSQL.Parameters.AddWithValue("@id", objFornecedor.id);

                    conexao.Open();
                    execSQL.ExecuteNonQuery();

                    return true;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro" + erro);
                    return false;
                }
                finally
                {
                    conexao.Close();
                }
            }



        }
}

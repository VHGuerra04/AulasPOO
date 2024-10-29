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
    internal class ClienteDAO
    {
        private MySqlConnection conexao;

        /*método construtor 
         Ivocado toda vez que a classe é instaciada 
         */
        public ClienteDAO()
        {
            this.conexao = new ConexaoBD().GetConnection();
        }

        public bool CadastrarCliente(cliente objCliente)
        {
            try
            {
                string sql = @"insert into clientes (nome, rg, cpf, email, telefone, 
                celular, cep, endereco, numero, complemento, bairro, cidade, estado) values(@nome, @rg, @cpf, @email, @telefone, 
                @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand execSQL = new MySqlCommand(sql, conexao);
                execSQL.Parameters.AddWithValue("@nome", objCliente.Nome);
                execSQL.Parameters.AddWithValue("@rg", objCliente.RG);
                execSQL.Parameters.AddWithValue("@cpf", objCliente.CPF);
                execSQL.Parameters.AddWithValue("@email", objCliente.Email);
                execSQL.Parameters.AddWithValue("@telefone", objCliente.Telefone);
                execSQL.Parameters.AddWithValue("@celular", objCliente.Celular);
                execSQL.Parameters.AddWithValue("@cep", objCliente.CEP);
                execSQL.Parameters.AddWithValue("@endereco", objCliente.Endereco);
                execSQL.Parameters.AddWithValue("@numero", objCliente.Numero);
                execSQL.Parameters.AddWithValue("@complemento", objCliente.Comlemento);
                execSQL.Parameters.AddWithValue("@bairro", objCliente.Bairro);
                execSQL.Parameters.AddWithValue("@cidade", objCliente.Cidade);
                execSQL.Parameters.AddWithValue("@estado", objCliente.Estado);

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

        public DataTable ListarClientes()
        {
            try 
	        {	        
		        DataTable clientes = new DataTable();
                string sql = "select * from clientes";

                MySqlCommand execSql = new MySqlCommand(sql, conexao);

                conexao.Open();
                execSql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(execSql);
                da.Fill(clientes);

                return clientes;

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
        
        public DataTable PesquisarClientePorNome(string nome)
        {
            try
            {
                DataTable clientes = new DataTable();
                string sql = "select * from clientes where nome like @nome";

                MySqlCommand execSql = new MySqlCommand(sql, conexao);

                conexao.Open();
                execSql.Parameters.AddWithValue("@nome", nome);
                execSql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(execSql);
                da.Fill(clientes);

                return clientes;

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

        public bool AlterarCliente(cliente objCliente)
        {
            try
            {
                string sql = @"UPDATE vendas.clientes
SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, 
endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
WHERE id=@id;";

                MySqlCommand execSQL = new MySqlCommand(sql, conexao);
                execSQL.Parameters.AddWithValue("@nome", objCliente.Nome);
                execSQL.Parameters.AddWithValue("@rg", objCliente.RG);
                execSQL.Parameters.AddWithValue("@cpf", objCliente.CPF);
                execSQL.Parameters.AddWithValue("@email", objCliente.Email);
                execSQL.Parameters.AddWithValue("@telefone", objCliente.Telefone);
                execSQL.Parameters.AddWithValue("@celular", objCliente.Celular);
                execSQL.Parameters.AddWithValue("@cep", objCliente.CEP);
                execSQL.Parameters.AddWithValue("@endereco", objCliente.Endereco);
                execSQL.Parameters.AddWithValue("@numero", objCliente.Numero);
                execSQL.Parameters.AddWithValue("@complemento", objCliente.Comlemento);
                execSQL.Parameters.AddWithValue("@bairro", objCliente.Bairro);
                execSQL.Parameters.AddWithValue("@cidade", objCliente.Cidade);
                execSQL.Parameters.AddWithValue("@estado", objCliente.Estado);
                execSQL.Parameters.AddWithValue("@id", objCliente.id);

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

        public bool ExcluirCliente(cliente objcliente)
        {
            try
            {
                string sql = @"delete from clientes where id = @id";

                MySqlCommand execSQL = new MySqlCommand(sql, conexao);
                execSQL.Parameters.AddWithValue("@id", objcliente.id);

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

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.conexao
{
    internal class ConexaoBD
    {
        public MySqlConnection GetConnection()
        {
            string conexao = "Server=localhost; Database=vendas; Uid=root; Pwd=setrem";

            return new MySqlConnection(conexao);

        }
    }
}

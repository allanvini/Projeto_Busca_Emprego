using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuscaEmprego.DAO
{
    class CadastroDAO
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public void cadastraCandidato(string CPF, string NOME, string IDADE, string CURRICULO, string SENHA)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL cadastraCandidato(?CPF, ?NOME, ?IDADE, ?CURRICULO, ?SENHA);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CPF", CPF);
                command.Parameters.AddWithValue("?NOME", NOME);
                command.Parameters.AddWithValue("?IDADE", IDADE);
                command.Parameters.AddWithValue("?CURRICULO", CURRICULO);
                command.Parameters.AddWithValue("?SENHA", SENHA);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void cadastraEmpresa(string CNPJ, string NOME, string ENDERECO, string SENHA)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL cadastraEmpresa(?CNPJ, ?NOME, ?ENDERECO, ?SENHA)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CNPJ", CNPJ);
                command.Parameters.AddWithValue("?NOME", NOME);
                command.Parameters.AddWithValue("?ENDERECO", ENDERECO);
                command.Parameters.AddWithValue("?SENHA", SENHA);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

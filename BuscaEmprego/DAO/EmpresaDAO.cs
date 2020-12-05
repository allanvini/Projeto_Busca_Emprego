using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuscaEmprego.DAO
{
    class EmpresaDAO
    {
        private String cnpj;
        private String nome;
        private String endereco;

        private MySqlConnection con;
        private Connection.Connection connection;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public void pegaDadosEmpresa(string CNPJ)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL pegaDadosEmpresa(?CNPJ);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CNPJ", CNPJ);
                command.ExecuteNonQuery();
                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();

                MySqlDR.Read();

                this.Cnpj = MySqlDR.GetString(0);
                this.Nome = MySqlDR.GetString(1);
                this.Endereco = MySqlDR.GetString(2);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void aprovaCandidato(string Vaga_ID, string Empresa_ID, string Candidato_ID, string Mensagem_Convite)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL aprovaCandidatura(?Vaga_ID, ?Empresa_ID, ?Candidato_ID, ?Mensagem_Convite);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?Vaga_ID", Vaga_ID);
                command.Parameters.AddWithValue("?Empresa_ID", Empresa_ID);
                command.Parameters.AddWithValue("?Candidato_ID", Candidato_ID);
                command.Parameters.AddWithValue("?Mensagem_Convite", Mensagem_Convite);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Candidatura aprovada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void reprovaCandidato(string vagaID, string empresaID, string candidatoID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getconnectionString();

            string query = "CALL reprovaCandidatura(?vagaID, ?empresaID, ?candidatoID)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?VagaID", vagaID);
                command.Parameters.AddWithValue("?empresaID", empresaID);
                command.Parameters.AddWithValue("?candidatoID", candidatoID);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Close();
                MessageBox.Show("Candidatura reprovada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void removeVaga(string VagaID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL removeVaga(?VagaID)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?VagaID", VagaID);

                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Vaga removida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void adicionaVaga(string CNPJ, string TituloVaga, string DescricaoVaga)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL cadastraVaga(?CNPJ, ?TituloVaga, ?DescricaoVaga);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CNPJ", CNPJ);
                command.Parameters.AddWithValue("?TituloVaga", TituloVaga);
                command.Parameters.AddWithValue("?DescricaoVaga", DescricaoVaga);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Vaga anunciada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuscaEmprego.DAO
{
    class CandidatoDAO
    {
        private String cpf;
        private String nome;
        private String idade;
        private String curriculo;

        private MySqlConnection con;
        private Connection.Connection connection;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Idade { get => idade; set => idade = value; }
        public string Curriculo { get => curriculo; set => curriculo = value; }

        public void pegaDadosCandidato(string CPF)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL pegaDadosCandidato(?CPF)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CPF", CPF);
                command.ExecuteNonQuery();
                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();

                MySqlDR.Read();

                this.Cpf = MySqlDR.GetString(0);
                this.Nome = MySqlDR.GetString(1);
                this.Idade = MySqlDR.GetString(2);
                this.Curriculo = MySqlDR.GetString(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void candidataParaVaga(string VAGA_ID, string EMPRESA_ID, string CANDIDATO_ID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL candidataParaVaga(?VAGA_ID, ?EMPRESA_ID, ?CANDIDATO_ID);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?VAGA_ID", VAGA_ID);
                command.Parameters.AddWithValue("?EMPRESA_ID", EMPRESA_ID);
                command.Parameters.AddWithValue("?CANDIDATO_ID", CANDIDATO_ID);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Candidatura efetuada com sucesso!\nAgora é com a empresa, não se esqueça de sempre verificar sua caixa de convites.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void removeCandidatura(string candidaturaID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            string query = "CALL removeCandidatura(?candidaturaID);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?candidaturaID", candidaturaID);
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Candidatura removida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuscaEmprego.DAO
{
    class LoginDAO
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public Boolean verificaLoginCandidato(String CPF, String Senha)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            String query = "CALL logaCandidato(?CPF, ?Senha);";
             
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?CPF", CPF);
                command.Parameters.AddWithValue("?Senha", Senha);

                MySqlDataReader MySqlDR = command.ExecuteReader();

                return MySqlDR.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean verificaLoginEmpresa(String CNPJ, String Senha)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getconnectionString();

            String query = "CALL logaEmpresa(?cnpj, ?Senha);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?cnpj", CNPJ);
                command.Parameters.AddWithValue("?Senha", Senha);

                MySqlDataReader MySqlDR = command.ExecuteReader();

                return MySqlDR.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

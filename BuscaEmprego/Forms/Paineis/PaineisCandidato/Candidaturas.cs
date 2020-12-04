using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BuscaEmprego.Forms.Paineis.PaineisCandidato
{
    public partial class Candidaturas : Form
    {

        private Connection.Connection connection;
        public Candidaturas()
        {
            InitializeComponent();
        }

        public Candidaturas(string CPF)
        {
            InitializeComponent();
            lblCandidatoID.Text = CPF;
        }

        private void Candidaturas_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void carregaDados()
        {
            connection = new Connection.Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string CPF = lblCandidatoID.Text;

            string connectionString = connection.getconnectionString();

            string query = "CALL candidaturasEnviadas(?CPF);";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?CPF", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?CPF"].Value = CPF;
                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for(int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dataGridView1.Rows.Add  (
                                                       dataTable.Rows[index][0],
                                                       dataTable.Rows[index][1],
                                                       dataTable.Rows[index][2],
                                                       dataTable.Rows[index][3],
                                                       dataTable.Rows[index][4]
                                                    );
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowindex = dataGridView1.SelectedCells[0].RowIndex;

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txbCandidaturaID.Text = Convert.ToString(row.Cells[0].Value);
                txbVagaID.Text = Convert.ToString(row.Cells[1].Value);
                txbEmpresa.Text = Convert.ToString(row.Cells[2].Value);
                txbVaga.Text = Convert.ToString(row.Cells[3].Value);
                txbDescricao.Text = Convert.ToString(row.Cells[4].Value);
            }
        }

        private void btnRemoverCandidatura_Click(object sender, EventArgs e)
        {
            string candidaturaID = txbCandidaturaID.Text;

            Models.Candidato candidato = new Models.Candidato();

            candidato.ID_Candidatura1 = candidaturaID;

            candidato.removeCandidatura();

            carregaDados();
        }
    }
}

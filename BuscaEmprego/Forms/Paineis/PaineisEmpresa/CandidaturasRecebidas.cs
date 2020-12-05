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

namespace BuscaEmprego.Forms.Paineis.PaineisEmpresa
{
    public partial class CandidaturasRecebidas : Form
    {
        private Connection.Connection connection;
        public CandidaturasRecebidas()
        {
            InitializeComponent();
        }

        public CandidaturasRecebidas(string CNPJ)
        {
            InitializeComponent();
            lblEmpresaID.Text = CNPJ;
        }

        private void btnAprovaCandidato_Click(object sender, EventArgs e)
        {
            string vagaID = txbVagaID.Text;
            string CNPJ = lblEmpresaID.Text;
            string candidatoID = txbCandidatoID.Text;

            Models.Empresa empresa = new Models.Empresa();

            empresa.Cnpj = CNPJ;
            empresa.VagaID = vagaID;
            empresa.CandidatoID = candidatoID;

            empresa.pegarDados();
            empresa.aprovarCandidatura();

        }

        private void btnReprovaCandidato_Click(object sender, EventArgs e)
        {
            string vagaID = txbVagaID.Text;
            string cnpj = lblEmpresaID.Text;
            string cpf = txbCandidatoID.Text;

            Models.Empresa empresa = new Models.Empresa();

            empresa.VagaID = vagaID;
            empresa.Cnpj = cnpj;
            empresa.CandidatoID = cpf;

            empresa.reprovaCandidatura();
        }

        private void btnAtualizaLista_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CandidaturasRecebidas_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txbCandidaturaID.Text = Convert.ToString(row.Cells[0].Value);
                txbVaga.Text = Convert.ToString(row.Cells[1].Value);
                txbVagaID.Text = Convert.ToString(row.Cells[2].Value);
                txbCandidato.Text = Convert.ToString(row.Cells[3].Value);
                txbCandidatoID.Text = Convert.ToString(row.Cells[4].Value);
                txbCurriculo.Text = Convert.ToString(row.Cells[5].Value);
            }
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string CNPJ = lblEmpresaID.Text;

            string connectionString = connection.getconnectionString();

            string query = "CALL candidaturasRecebidas(?CNPJ);";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?CNPJ", (MySqlDbType)SqlDbType.BigInt);
                    command.Parameters["?CNPJ"].Value = CNPJ;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dataGridView1.Rows.Add(
                                                       dataTable.Rows[index][0],
                                                       dataTable.Rows[index][1],
                                                       dataTable.Rows[index][2],
                                                       dataTable.Rows[index][3],
                                                       dataTable.Rows[index][4],
                                                       dataTable.Rows[index][5]
                                                    );
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }
    }
}

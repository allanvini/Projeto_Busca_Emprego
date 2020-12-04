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
    public partial class Vagas : Form
    {

        private Connection.Connection connection;
        public Vagas()
        {
            InitializeComponent();
        }
        public Vagas(String candidatoID)
        {
            InitializeComponent();
            lblCandidatoID.Text = candidatoID;
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = connection.getconnectionString();

            string query = "SELECT * FROM verVagas;";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for(int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[index][0],
                                                   dataTable.Rows[index][1],
                                                   dataTable.Rows[index][2],
                                                   dataTable.Rows[index][3],
                                                   dataTable.Rows[index][4]
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txbIDVaga.Text = Convert.ToString(row.Cells[0].Value);
                txbNomeEmpresa.Text = Convert.ToString(row.Cells[1].Value);
                txbEmpresaID.Text = Convert.ToString(row.Cells[2].Value);
                txbTituloVaga.Text = Convert.ToString(row.Cells[3].Value);
                txbDescricao.Text = Convert.ToString(row.Cells[4].Value);
            }
        }

        private void Vagas_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCandidata_Click(object sender, EventArgs e)
        {
            string CPF = lblCandidatoID.Text;
            string Empresa_ID = txbEmpresaID.Text;
            string Vaga_ID = txbIDVaga.Text;

            Models.Candidato candidato = new Models.Candidato();

            candidato.Empresa_ID1 = Empresa_ID;
            candidato.Cpf = CPF;
            candidato.ID_Vaga1 = Vaga_ID;

            candidato.candidataParaVaga();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}

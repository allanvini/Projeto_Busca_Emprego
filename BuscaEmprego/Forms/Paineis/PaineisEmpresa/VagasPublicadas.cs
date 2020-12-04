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
    public partial class VagasPublicadas : Form
    {
        private Connection.Connection connection;
        public VagasPublicadas()
        {
            InitializeComponent();
        }
        public VagasPublicadas(string CNPJ)
        {
            InitializeComponent();
            lblEmpresaID.Text = CNPJ;
        }

        public void carregarDados()
        {
            connection = new Connection.Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string CNPJ = lblEmpresaID.Text;

            string connectionString = connection.getconnectionString();

            string query = "CALL verVagasCadastradas(?CNPJ);";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?CNPJ", (MySqlDbType)SqlDbType.BigInt);
                    command.Parameters["?CNPJ"].Value = CNPJ;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try{
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dataGridView1.Rows.Add(
                                                       dataTable.Rows[index][0],
                                                       dataTable.Rows[index][1],
                                                       dataTable.Rows[index][2]
                                                    );
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txbVagaID.Text = Convert.ToString(row.Cells[0].Value);
                txbTituloVaga.Text = Convert.ToString(row.Cells[1].Value);
                txbDescricaoVaga.Text = Convert.ToString(row.Cells[2].Value);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btnAdicionarVaga_Click(object sender, EventArgs e)
        {
            string CNPJ = lblEmpresaID.Text;

            Forms.Paineis.PaineisEmpresa.AdicionarVaga painelAdicionarVaga = new Forms.Paineis.PaineisEmpresa.AdicionarVaga(CNPJ);

            painelAdicionarVaga.ShowDialog();
        }

        private void btnRemoverVaga_Click(object sender, EventArgs e)
        {
            string VagaID = txbVagaID.Text;

            Models.Empresa empresa = new Models.Empresa();

            empresa.VagaID = VagaID;

            empresa.removeVaga();

            carregarDados();
        }

        private void VagasPublicadas_Load(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}

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
    public partial class Convites : Form
    {
        private Connection.Connection connection;
        public Convites()
        {
            InitializeComponent();
        }
        public Convites(string CPF)
        {
            InitializeComponent();
            lblCandidatoID.Text = CPF;
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string CPF = lblCandidatoID.Text;

            string connectionString = connection.getconnectionString();

            string query = "CALL verConvites(?CPF);";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?CPF", (MySqlDbType)SqlDbType.BigInt);
                    command.Parameters["?CPF"].Value = CPF;
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
                                                       dataTable.Rows[index][2]
                                                    );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowindex = dataGridView1.SelectedCells[0].RowIndex;

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txbVaga.Text = Convert.ToString(row.Cells[0].Value);
                txbEmpresa.Text = Convert.ToString(row.Cells[1].Value);
                txbDescricao.Text = Convert.ToString(row.Cells[2].Value);
            }
        }

        private void Convites_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}

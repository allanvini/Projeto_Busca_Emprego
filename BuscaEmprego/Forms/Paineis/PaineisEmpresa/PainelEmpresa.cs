using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaEmprego.Forms.Paineis.PaineisEmpresa
{
    public partial class PainelEmpresa : Form
    {
        public PainelEmpresa()
        {
            InitializeComponent();
        }

        public PainelEmpresa(String CNPJ, String Nome)
        {
            InitializeComponent();

            lblCNPJEmpresa.Text = CNPJ;
            lblNomeEmpresa.Text = Nome;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerCandidaturas_Click(object sender, EventArgs e)
        {
            string CNPJ = lblCNPJEmpresa.Text;

            Forms.Paineis.PaineisEmpresa.CandidaturasRecebidas painelCandidaturas = new Forms.Paineis.PaineisEmpresa.CandidaturasRecebidas(CNPJ);

            painelCandidaturas.ShowDialog();
        }

        private void btnVerVagas_Click(object sender, EventArgs e)
        {
            string CNPJ = lblCNPJEmpresa.Text;

            Forms.Paineis.PaineisEmpresa.VagasPublicadas painelVagasPublicadas = new Forms.Paineis.PaineisEmpresa.VagasPublicadas(CNPJ);

            painelVagasPublicadas.ShowDialog();
        }
    }
}

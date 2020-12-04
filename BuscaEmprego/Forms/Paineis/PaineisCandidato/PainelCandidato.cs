using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaEmprego.Forms.Paineis.PaineisCandidato
{
    public partial class PainelCandidato : Form
    {
        public PainelCandidato()
        {
            InitializeComponent();
        }
        public PainelCandidato(String CPF, String Nome)
        {
            InitializeComponent();
            lblCPFCandidato.Text = CPF;
            lblNomeCandidato.Text = Nome;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerVagas_Click(object sender, EventArgs e)
        {
            string CPF = lblCPFCandidato.Text;

            Forms.Paineis.PaineisCandidato.Vagas painelVagas = new Forms.Paineis.PaineisCandidato.Vagas(CPF);

            painelVagas.ShowDialog();
        }

        private void btnVerCandidaturas_Click(object sender, EventArgs e)
        {
            string CPF = lblCPFCandidato.Text;

            Forms.Paineis.PaineisCandidato.Candidaturas painelCandidaturas = new Forms.Paineis.PaineisCandidato.Candidaturas(CPF);

            painelCandidaturas.ShowDialog();
        }

        private void btnVerConvites_Click(object sender, EventArgs e)
        {
            string CPF = lblCPFCandidato.Text;

            Forms.Paineis.PaineisCandidato.Convites painelConvites = new Forms.Paineis.PaineisCandidato.Convites(CPF);

            painelConvites.ShowDialog();
        }
    }
}

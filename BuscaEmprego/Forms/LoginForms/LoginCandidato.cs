using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaEmprego.Forms
{
    public partial class LoginCandidato : Form
    {
        public LoginCandidato()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string cpf = txbCPFLogin.Text;
            string senha = txbSenhaLogin.Text;

            Models.Login login = new Models.Login();

            login.Cpf = cpf;
            login.Senha = senha;

            if (login.logaCandidato())
            {
                this.Hide();

                string CPF = txbCPFLogin.Text;

                Models.Candidato candidato = new Models.Candidato();

                candidato.Cpf = CPF;

                candidato.pegarDados();

                Forms.Paineis.PaineisCandidato.PainelCandidato painelCandidato = new Forms.Paineis.PaineisCandidato.PainelCandidato(candidato.Cpf, candidato.Nome);

                painelCandidato.ShowDialog();

            }
            else
            {
                MessageBox.Show("CPF ou Senha incorretos!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Forms.CadastroForms.CadastroCandidato cadastraCandidato = new Forms.CadastroForms.CadastroCandidato();

            cadastraCandidato.ShowDialog();
        }
    }
}

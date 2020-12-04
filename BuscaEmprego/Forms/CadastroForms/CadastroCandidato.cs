using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaEmprego.Forms.CadastroForms
{
    public partial class CadastroCandidato : Form
    {
        public CadastroCandidato()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string CPF = txbCPF.Text;
            string Nome = txbNome.Text;
            string Idade = txbNome.Text;
            string Senha = txbSenha.Text;
            string Curriculo = txbCurriculo.Text;

            DAO.CadastroDAO cadastro = new DAO.CadastroDAO();

            cadastro.cadastraCandidato(CPF, Nome, Idade, Curriculo, Senha);

            this.Close();
        }
    }
}

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
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string CNPJ = txbCNPJ.Text;
            string Nome = txbNome.Text;
            string Endereco = txbEndereco.Text;
            string Senha = txbSenha.Text;

            DAO.CadastroDAO cadastro = new DAO.CadastroDAO();

            cadastro.cadastraEmpresa(CNPJ, Nome, Endereco, Senha);

            this.Close();
        }
    }
}

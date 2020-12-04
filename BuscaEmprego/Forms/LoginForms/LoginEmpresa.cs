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
    public partial class LoginEmpresa : Form
    {
        public LoginEmpresa()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string cnpj = txbCNPJLogin.Text;
            string senha = txbSenhaLogin.Text;

            Models.Login login = new Models.Login();

            login.Cnpj = cnpj;
            login.Senha = senha;

            if (login.logaEmpresa())
            {
                this.Hide();

                string CNPJ = txbCNPJLogin.Text;

                Models.Empresa empresa = new Models.Empresa();

                empresa.Cnpj = CNPJ;

                empresa.pegarDados();

                Forms.Paineis.PaineisEmpresa.PainelEmpresa painelEmpresa = new Forms.Paineis.PaineisEmpresa.PainelEmpresa(empresa.Cnpj, empresa.NomeEmpresa);

                painelEmpresa.ShowDialog();
            }
            else
            {
                MessageBox.Show("CNPJ ou Senha incorretos!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Forms.CadastroForms.CadastroEmpresa cadastraEmpresa = new Forms.CadastroForms.CadastroEmpresa();

            cadastraEmpresa.ShowDialog();
        }
    }
}

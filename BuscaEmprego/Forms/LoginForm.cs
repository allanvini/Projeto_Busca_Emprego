using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaEmprego
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCandidatoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Forms.LoginCandidato candidato = new Forms.LoginCandidato();

            candidato.ShowDialog();
        }

        private void btnEmpresaLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Forms.LoginEmpresa empresa = new Forms.LoginEmpresa();

            empresa.ShowDialog();
        }
    }
}

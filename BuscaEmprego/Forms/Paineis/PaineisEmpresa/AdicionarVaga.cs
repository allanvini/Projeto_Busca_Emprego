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
    public partial class AdicionarVaga : Form
    {
        public AdicionarVaga()
        {
            InitializeComponent();
        }
        public AdicionarVaga(string CNPJ)
        {
            InitializeComponent();
            lblEmpresaID.Text = CNPJ;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string CNPJ = lblEmpresaID.Text;
            string tituloVaga = txbTituloVaga.Text;
            string descricaoVaga = txbDescricaoVaga.Text;

            Models.Empresa empresa = new Models.Empresa();

            empresa.Cnpj = CNPJ;
            empresa.TituloVaga = tituloVaga;
            empresa.DescricaoVaga = descricaoVaga;

            empresa.adicionaVaga();

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

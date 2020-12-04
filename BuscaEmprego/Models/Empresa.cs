using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaEmprego.Models
{
    class Empresa
    {
        private String cnpj;
        private String nomeEmpresa;
        private String enderecoEmpresa;
        private String candidaturaID;
        private String vagaID;
        private String candidatoID;
        private String tituloVaga;
        private String descricaoVaga;

        private String mensagemConvite;

        private DAO.EmpresaDAO edao;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeEmpresa { get => nomeEmpresa; set => nomeEmpresa = value; }
        public string EnderecoEmpresa { get => enderecoEmpresa; set => enderecoEmpresa = value; }
        public string CandidaturaID { get => candidaturaID; set => candidaturaID = value; }
        public string VagaID { get => vagaID; set => vagaID = value; }
        public string CandidatoID { get => candidatoID; set => candidatoID = value; }
        public string TituloVaga { get => tituloVaga; set => tituloVaga = value; }
        public string DescricaoVaga { get => descricaoVaga; set => descricaoVaga = value; }

        public void pegarDados()
        {
            edao = new DAO.EmpresaDAO();

            edao.pegaDadosEmpresa(Cnpj);

            this.NomeEmpresa = edao.Nome;
            this.EnderecoEmpresa = edao.Endereco;
        }

        public void aprovarCandidatura()
        {
            edao = new DAO.EmpresaDAO();

            this.mensagemConvite = "Olá, você foi aprovado para a nossa vaga "+this.vagaID+" da empresa "+this.nomeEmpresa+" por vaor compareça ao endereço "+this.enderecoEmpresa+"\nObrigado!";

            edao.aprovaCandidato(VagaID, Cnpj, CandidatoID, mensagemConvite);
        }

        public void removeVaga()
        {
            edao = new DAO.EmpresaDAO();

            edao.removeVaga(vagaID);
        }

        public void adicionaVaga()
        {
            edao = new DAO.EmpresaDAO();

            edao.adicionaVaga(cnpj, tituloVaga, descricaoVaga);
        }

    }
}

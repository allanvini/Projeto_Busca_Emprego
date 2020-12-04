using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaEmprego.Models
{
    class Candidato
    {
        private String cpf;
        private String nome;
        private String idade;
        private String curriculo;
        private String ID_Vaga;
        private String Empresa_ID;
        private String ID_Candidatura;
        private DAO.CandidatoDAO cdao;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Idade { get => idade; set => idade = value; }
        public string Curriculo { get => curriculo; set => curriculo = value; }
        public string ID_Vaga1 { get => ID_Vaga; set => ID_Vaga = value; }
        public string Empresa_ID1 { get => Empresa_ID; set => Empresa_ID = value; }
        public string ID_Candidatura1 { get => ID_Candidatura; set => ID_Candidatura = value; }

        public void pegarDados()
        {
            cdao = new DAO.CandidatoDAO();

            cdao.pegaDadosCandidato(cpf);

            this.Nome = cdao.Nome;
            this.Idade = cdao.Idade;
            this.Curriculo = cdao.Curriculo;
        }

        public void candidataParaVaga()
        {
            cdao = new DAO.CandidatoDAO();

            cdao.candidataParaVaga(ID_Vaga, Empresa_ID, cpf);
        }

        public void removeCandidatura()
        {
            cdao = new DAO.CandidatoDAO();

            cdao.removeCandidatura(ID_Candidatura);
        }
    }
}

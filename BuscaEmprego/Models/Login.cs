using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaEmprego.Models
{
    class Login
    {
        private String cpf;
        private String cnpj;
        private String senha;
        private DAO.LoginDAO ldao;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Senha { get => senha; set => senha = value; }

        public Boolean logaCandidato()
        {
            ldao = new DAO.LoginDAO();
            return ldao.verificaLoginCandidato(cpf, senha);
        }
        
        public Boolean logaEmpresa()
        {
            ldao = new DAO.LoginDAO();
            return ldao.verificaLoginEmpresa(cnpj, senha);
        }
        
    }
}

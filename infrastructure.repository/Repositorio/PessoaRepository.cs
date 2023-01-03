using Dominio;
using infrastructure.repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.repository.Repositorio
{
    public class PessoaRepository : IPessoaRepository
    {
        public Pessoa AlterarCadastro(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Pessoa BuscarPessoa(int cpf)
        {
            throw new NotImplementedException();
        }

        public IList<Pessoa> BuscarPessoas()
        {
            throw new NotImplementedException();
        }

        public bool CadastrarPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirCadastro(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}

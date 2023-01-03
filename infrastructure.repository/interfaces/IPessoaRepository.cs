using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.repository.interfaces
{
    public interface IPessoaRepository
    {
        //criar uma nova pessoa
        bool CadastrarPessoa(Pessoa pessoa);
        //ler as informaçoes de das as pessoas que estiverem no cadastro
        IList<Pessoa> BuscarPessoas();
        Pessoa BuscarPessoa(int cpf);

        // altera o cadastro de uma pessoa
        Pessoa AlterarCadastro(Pessoa pessoa);
        // remove o cadastro de uma pessoa
        bool ExcluirCadastro(Pessoa pessoa);


    }
}

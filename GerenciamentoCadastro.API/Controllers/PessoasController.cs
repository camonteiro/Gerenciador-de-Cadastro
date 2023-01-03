using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCadastro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private List<Pessoa> _pessoa1 { get; set; }

        public PessoasController() 
        {
            _pessoa1 = new List<Pessoa>()
            {
                new Pessoa{
                    Nome = "Carolina",
                    CPF = 80808080800,
                    DataDeNascimento = DateTime.Parse("16-02-1981"),
                    Email = "ca.monteiro16@gmail.com",
                    Telefone = "(51) 98556-9495"
                },
                new Pessoa{
                    Nome = "Abel",
                    CPF = 466587987478,
                    DataDeNascimento = DateTime.Parse("21-04-1979"),
                    Email = "abellopes@gmail.com",
                    Telefone = "(51) 98102-1106"
                }
            };

        }

        [HttpGet]
        public List<Pessoa> Get()
        {        

            return _pessoa1;
        }


        [HttpPost]

        public Pessoa CadastrarPessoa([FromBody]Pessoa pessoa)
        {

            _pessoa1.Add(pessoa);

            return pessoa;
        }

    }
}

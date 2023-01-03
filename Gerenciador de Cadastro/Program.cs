using Dominio;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Gerenciador_de_Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa()
            {
                Nome = "Carolina",
                CPF = 80559204000,
                DataDeNascimento = DateTime.Parse("16-02-1981"),
                Email= "ca.monteiro16@gmail.com",
                Telefone = "(51) 98556-9495"
            };


            Console.WriteLine($"NOME: {pessoa1.Nome}");
            Console.WriteLine($"CPF: {pessoa1.CPF}");
            Console.WriteLine($"EMAIL: {pessoa1.Email}");
            Console.WriteLine($"TELEFONE: {pessoa1.Telefone}");
            Console.WriteLine($"DATA DE NASCIMENTO: {pessoa1.DataDeNascimento}");

        }
    }
}

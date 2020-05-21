using System;
using System.Collections.Generic;
using Alunos;

namespace Desafio21DiasOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisicas = new Fisica().Todos();
            var jurificas = new Juridica().Todos();

            foreach(var item in fisicas)
            {
                ((Fisica)item).Salvar();

                Console.WriteLine(item);
            }

            foreach (var item in jurificas)
            {
                ((Juridica)item).Salvar();

                Console.WriteLine(item);
            }


            new Fisica() { Nome = "Danilo", Endereco = "Tornese um programador", Id = 1 }.Salvar();
            new Juridica() { Nome = "Empresa Danilo", Endereco = "Tornese um programador", Id = 1 }.Salvar();


            //var listaPessoa = Servico.BuscaPorNome<List<Pessoa>>("danilo");

            //usuario.NomePersonalizado();
            //Console.WriteLine(usuario.Nome);
            /*var danilo = new Pessoa();
            danilo.Id = 1;
            danilo.Nome = "Danilo Aparecido";
            danilo.Endereco = "Rua 1234";

            var wagner = new Pessoa();
            wagner.Id = 2;
            wagner.Nome = "Wagner Braga";
            wagner.Endereco = "Rua 1234";

            var marcos = new Pessoa();
            marcos.Id = 3;
            marcos.Nome = "Marcos Palladino";
            marcos.Endereco = "Rua 1234";

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(danilo);
            pessoas.Add(wagner);
            pessoas.Add(marcos);

            Console.WriteLine("Hello World!");
            */
        }
    }
}

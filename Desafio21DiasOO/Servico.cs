using System;
using System.Collections.Generic;

namespace Alunos
{
    public class Servico
    {
        public static List<Fisica> TabelaFisica = new List<Fisica>();
        public static List<Juridica> TabelaJuridica = new List<Juridica>();
        private IPessoa pessoa;

        public Servico()
        {
        }

        public Servico(IPessoa iPessoa)
        {
            this.pessoa = iPessoa;
        }

        public List<IPessoa> Todos()
        {
            var lista = new List<IPessoa>();

            if(pessoa.GetType() == typeof(Fisica))
            {
                lista.Add(new Fisica() { Nome = "Fisica" });
            }
            else
            {
                lista.Add(new Juridica() { Nome = "Juridica" });
            }

            return lista;
        }

        public static void Salvar(IPessoa iPessoa)
        {
            if (iPessoa.GetType().Name == "Fisica")
            {
                Servico.TabelaFisica.Add((Fisica)iPessoa);
            }
            else if(iPessoa.GetType().Name == "Juridica")
            {
                Servico.TabelaJuridica.Add((Juridica)iPessoa);
            }
        }

        public static void Excluir(IPessoa iPessoa)
        {
            if (iPessoa.GetType().Name == "Fisica")
            {
                Servico.ExcluirPessoaFisica((Fisica)iPessoa);
            }
            else if (iPessoa.GetType().Name == "Juridica")
            {
                Servico.ExcluirPessoaJuridica((Juridica)iPessoa);
            }
        }

        private static void ExcluirPessoaJuridica(Juridica iPessoa)
        {
            throw new NotImplementedException();
        }

        private static void ExcluirPessoaFisica(Fisica iPessoa)
        {
            throw new NotImplementedException();
        }

        public static T BuscaPorNome<T>(string nome)
        {
            List<IPessoa> lista = new List<IPessoa>();
            return (T)Convert.ChangeType(lista, typeof(T));
        }
    }
}

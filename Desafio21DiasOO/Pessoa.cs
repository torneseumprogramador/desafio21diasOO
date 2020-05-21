using System;
using System.Collections.Generic;

namespace Alunos
{
    public abstract class Pessoa: IPessoa
    {
        public Pessoa()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public abstract void Excluir();

        public List<IPessoa> Todos()
        {
            return new Servico(this).Todos();
        }

        public void Salvar()
        {
            Servico.Salvar(this);
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}

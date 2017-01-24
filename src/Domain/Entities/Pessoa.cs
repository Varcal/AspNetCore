using System;
using Domain.Entities.Core;

namespace Domain.Entities
{
    public class Pessoa: EntityBase
    {
        public string Nome { get; private set; }

        protected Pessoa()
        {
            
        }

        public Pessoa(string nome, bool ativo)
        {
            Nome = nome;
            DataCadastro = DateTime.Now;
            Ativo = ativo;
        }

        public void Alterar(string nome)
        {
            Nome = nome;
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class PessoaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public bool Ativo { get; set; }

        public PessoaViewModel()
        {
            
        }

        public PessoaViewModel(int id, string nome, DateTime dataCadastro, bool ativo)
        {
            Id = id;
            Nome = nome;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
    }
}

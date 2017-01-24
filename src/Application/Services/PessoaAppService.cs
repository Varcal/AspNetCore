using System;
using System.Collections.Generic;
using System.Linq;
using Application.Contracts;
using Application.Services.Core;
using Application.ViewModels;
using Domain.Contracts.Repositories;
using Domain.Entities;
using Infra.Data.UoW;

namespace Application.Services
{
    public class PessoaAppService : ApplicationService, IPessoaAppService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaAppService(IUnitOfWork uow, IPessoaRepository pessoaRepository)
            : base(uow)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<PessoaViewModel> SelecionarTodos()
        {
            var pessoas = _pessoaRepository.GetAll();

            return pessoas.Select(p => new PessoaViewModel(p.Id, p.Nome, p.DataCadastro, p.Ativo));
        }

        public bool Registrar(PessoaViewModel model)
        {

            var pessoa = new Pessoa(model.Nome, model.Ativo);

            _pessoaRepository.Add(pessoa);
            return Salvar();
        }

        public PessoaViewModel ObterPorId(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);

            return new PessoaViewModel(pessoa.Id, pessoa.Nome, pessoa.DataCadastro, pessoa.Ativo);
        }

        public bool Editar(PessoaViewModel model)
        {
            var pessoa = _pessoaRepository.GetById(model.Id);

            pessoa.Alterar(model.Nome);
            _pessoaRepository.Update(pessoa);

            return Salvar();
        }


        public bool Excluir(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);
            _pessoaRepository.Remove(pessoa);

            return Salvar();
        }
    }
}

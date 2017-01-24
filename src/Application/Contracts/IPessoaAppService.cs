using System.Collections.Generic;
using Application.ViewModels;

namespace Application.Contracts
{
    public interface IPessoaAppService
    {
        IEnumerable<PessoaViewModel> SelecionarTodos();
        PessoaViewModel ObterPorId(int id);
        bool Registrar(PessoaViewModel model);
        bool Editar(PessoaViewModel model);
        bool Excluir(int id);
    }
}

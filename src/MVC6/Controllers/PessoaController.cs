using Application.Contracts;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MVC6.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoaController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        public IActionResult Index()
        {
            var pessoas = _pessoaAppService.SelecionarTodos();

            if (TempData["mensagem"] != null)
                ViewData["mensagem"] = TempData["mensagem"].ToString();

            return View(pessoas);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(PessoaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (_pessoaAppService.Registrar(model))
            {
                TempData["mensagem"] = "Pessoa salva com sucesso!!!";
                return RedirectToAction("Index");
            }

            ViewData["Erro"] = "Não foi possível salvar essa pessoa!!!";
            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var pessoa = _pessoaAppService.ObterPorId(id);

            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Editar(PessoaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (_pessoaAppService.Editar(model))
            {
                TempData["mensagem"] = "Pessoa alterada com sucesso!!!";
                return RedirectToAction("Index");
            }

            ViewData["Erro"] = "Não foi possível salvar essa pessoa!!!";
            return View(model);
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            if (_pessoaAppService.Excluir(id))
            {
                TempData["mensagem"] = "Pessoa excluida com sucesso!!!";
                return RedirectToAction("Index");
            }

            ViewData["Erro"] = "Não foi possível salvar essa pessoa!!!";
            return View("Index");
        }
    }
}

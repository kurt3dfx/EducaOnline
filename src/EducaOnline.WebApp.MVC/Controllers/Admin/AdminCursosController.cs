using EducaOnline.Conteudo.Application.Services;
using EducaOnline.Conteudo.Application.ViewModels;
using EducaOnline.Conteudo.Domain;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EducaOnline.WebApp.MVC.Controllers.Admin
{
    public class AdminCursosController : Controller
    {
        private readonly ICursoAppService _cursoAppService;

        public AdminCursosController(ICursoAppService cursoAppService)
        {
            _cursoAppService = cursoAppService;
        }

        [HttpGet]
        [Route("admin/cursos")]
        public async Task<IActionResult> Index()
        {
            var cursos =  await _cursoAppService.ObterTodos();
            return View(cursos);
        }

        [Route("novo-curso")]
        public async Task<IActionResult> NovoCurso()
        {
            return View(await PopularCategorias(new CursoViewModel()));
        }

        [Route("novo-curso")]
        [HttpPost]
        public async Task<IActionResult> NovoCurso(CursoViewModel cursoViewModel)
        {
            if (!ModelState.IsValid) return View(await PopularCategorias(cursoViewModel));

            await _cursoAppService.AdicionarCurso(cursoViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("editar-curso")]
        public async Task<IActionResult> AtualizarCurso(Guid id)
        {            
            return View(await PopularCategorias(await _cursoAppService.ObterPorId(id)));
        }

        [Route("editar-curso")]
        [HttpPost]
        public async Task<IActionResult> AtualizarCurso(Guid id, CursoViewModel cursoViewModel)
        {
            if (!ModelState.IsValid) return View(await PopularCategorias(cursoViewModel));

            await _cursoAppService.AtualizarCurso(cursoViewModel);

            return RedirectToAction("Index");
        }

        private async Task<CursoViewModel> PopularCategorias(CursoViewModel curso)
        {
            curso.Categorias = await _cursoAppService.ObterCategorias();
            return curso;
        }



    }
}

using EducaOnline.Conteudo.Application.Services;
using EducaOnline.Conteudo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EducaOnline.Api.Controllers
{
    [ApiController]
    [Route("api/cursos")]
    public class CursosController : ControllerBase
    {
        private readonly ICursoAppService _cursoAppService;

        public CursosController(ICursoAppService cursoAppService)
        {
            _cursoAppService = cursoAppService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoViewModel>>> GetCursos()
        {
            var cursos = await _cursoAppService.ObterTodos();
            return Ok(cursos); // Wrap the result in Ok() to return a proper ActionResult
        }
    }
}

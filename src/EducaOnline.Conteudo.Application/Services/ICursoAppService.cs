using EducaOnline.Conteudo.Application.ViewModels;

namespace EducaOnline.Conteudo.Application.Services
{
    public interface ICursoAppService : IDisposable
    {
        Task<IEnumerable<CursoViewModel>> ObterTodos();
        Task<CursoViewModel> ObterPorId(Guid id);
        Task<IEnumerable<CursoViewModel>> ObterPorCategoria(int codigo);
        Task<IEnumerable<CategoriaViewModel>> ObterCategorias();
        Task AdicionarCurso(CursoViewModel cursoViewModel);
        Task AtualizarCurso(CursoViewModel cursoViewModel);
        Task RemoverCurso(Guid id);
    }
}

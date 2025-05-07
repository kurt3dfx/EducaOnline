using AutoMapper;
using EducaOnline.Conteudo.Application.ViewModels;
using EducaOnline.Conteudo.Domain;

namespace EducaOnline.Conteudo.Application.Services
{
    public class CursoAppService : ICursoAppService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IMapper _mapper;

        public CursoAppService(ICursoRepository cursoRepository,
                               IMapper mapper) 
        {
            _cursoRepository = cursoRepository;
            _mapper = mapper;
        }

        public async Task AdicionarCurso(CursoViewModel cursoViewModel)
        {
            var curso = _mapper.Map<Curso>(cursoViewModel);
            _cursoRepository.Adicionar(curso);

            await _cursoRepository.UnitOfWork.Commit();
        }
        public async Task AtualizarCurso(CursoViewModel cursoViewModel)
        {
            var curso = _mapper.Map<Curso>(cursoViewModel);
            _cursoRepository.Atualizar(curso);

            await _cursoRepository.UnitOfWork.Commit();
        }
        public async Task<IEnumerable<CategoriaViewModel>> ObterCategorias()
        {
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(await _cursoRepository.ObterCategorias());
        }
        public async Task<CursoViewModel> ObterPorId(Guid id)
        {
            return _mapper.Map<CursoViewModel>(await _cursoRepository.ObterPorId(id));
        }
        public async Task<IEnumerable<CursoViewModel>> ObterPorCategoria(int codigo)
        {
            return _mapper.Map<IEnumerable<CursoViewModel>>(await _cursoRepository.ObterPorCategoria(codigo));
        }
        public async Task<IEnumerable<CursoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CursoViewModel>>(await _cursoRepository.ObterTodos());
        }
        public Task RemoverCurso(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _cursoRepository.Dispose();
        }
    }

}

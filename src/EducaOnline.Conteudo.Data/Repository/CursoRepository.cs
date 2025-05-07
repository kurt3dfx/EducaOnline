using EducaOnline.Conteudo.Domain;
using EducaOnline.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace EducaOnline.Conteudo.Data.Repository
{
    public class CursoRepository : ICursoRepository
    {

        private readonly ConteudoContext _context;

        public CursoRepository(ConteudoContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Curso curso)
        {
            _context.Cursos.Add(curso);
        }

        public void Adicionar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
        }

        public void Adicionar(Aula aula)
        {
            _context.Aulas.Add(aula);
        }

        public void Atualizar(Curso curso)
        {
            _context.Cursos.Update(curso);
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }

        public void Atualizar(Aula aula)
        {
            _context.Aulas.Update(aula);
        }

        public async Task<IEnumerable<Categoria>> ObterCategorias()
        {
            return await _context.Categorias
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<Curso>> ObterPorCategoria(int codigo)
        {
            return await _context.Cursos
                .AsNoTracking()
                .Include(c => c.Categoria)
                .Where(c => c.Categoria.Codigo == codigo)
                .ToListAsync();
        }

        public async Task<Curso> ObterPorId(Guid id)
        {
            /*
            return await _context.Cursos
                .AsNoTracking()                
                .FirstOrDefaultAsync(c => c.Id == id);
            */
            var curso = _context.Cursos.Find(id);
            return curso;

            //return await _context.Cursos.FindAsync(id);
        }

        public async Task<IEnumerable<Curso>> ObterTodos()
        {
            return await _context.Cursos
                .AsNoTracking()
                .ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public Task<IEnumerable<Aula>> ObterAulasPorCurso(Guid cursoId)
        {
            throw new NotImplementedException();
        }

        public Task<Aula> ObterAulaPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

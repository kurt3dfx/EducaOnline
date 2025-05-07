using EducaOnline.Core.Data;

namespace EducaOnline.Conteudo.Domain
{
    public interface ICursoRepository : IRepository<Curso>
    {

        Task<IEnumerable<Curso>> ObterTodos();
        Task<Curso> ObterPorId(Guid id);
        Task<IEnumerable<Curso>> ObterPorCategoria(int codigo);
        Task<IEnumerable<Categoria>> ObterCategorias();


        void Adicionar(Curso curso);
        void Atualizar(Curso curso);

        void Adicionar(Categoria categoria);
        void Atualizar(Categoria categoria);

        void Adicionar(Aula aula);
        void Atualizar(Aula aula);


        // talvez separar em dois repositorios
        Task<IEnumerable<Aula>> ObterAulasPorCurso(Guid cursoId);
        Task<Aula> ObterAulaPorId(Guid id);

        //void Adicionar(Aluno aluno);
    }
}

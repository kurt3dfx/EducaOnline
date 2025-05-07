namespace EducaOnline.Conteudo.Domain
{
    public interface IMatriculaService : IDisposable
    {
        Task<bool> Matricular(Guid alunoId, Guid cursoId);
        //Task<bool> Desmatricular(Guid alunoId, Guid cursoId);
        //Task<bool> VerificarMatricula(Guid alunoId, Guid cursoId);
    }
}

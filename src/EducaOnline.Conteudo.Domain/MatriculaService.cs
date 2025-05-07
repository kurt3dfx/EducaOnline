using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaOnline.Conteudo.Domain
{

    //Trabalhe com linguagens de dominio para representar ações conhecidas pela sua linguage obliqua
    //Todo serviço de dominio tem que ser reconhecido pelo seu domain expert
    //Ele tem que enteder que tudo isso faz parte de um processo de negócio e um dominio de negócio só existe porque ele 
    //implementa regras de negócio que vão além da sua propria entidade (CRUD)

    public class MatriculaService : IMatriculaService
    {
        private readonly ICursoRepository _cursoRepository;

        public MatriculaService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository ?? throw new ArgumentNullException(nameof(cursoRepository));
        }

        public async Task<bool> Matricular(Guid alunoId, Guid cursoId)
        {
            // Await the repository call to fix CS1998
            var curso = await _cursoRepository.ObterPorId(cursoId);

            if (curso == null)
            {
                // Return false if the course is not found to fix CS0161
                return false;
            }

            // Simulate adding the course (assuming this is a valid operation)
            _cursoRepository.Adicionar(curso);
            return await _cursoRepository.UnitOfWork.Commit();
        }

        public async Task<bool> GerarCertificado(Guid alunoId, Guid cursoId)
        {
            // This is a placeholder implementation
            return await Task.FromResult(true);
        }

        public void Dispose()
        {
            // Implement IDisposable to clean up resources
            _cursoRepository?.Dispose();
        }
    }
}

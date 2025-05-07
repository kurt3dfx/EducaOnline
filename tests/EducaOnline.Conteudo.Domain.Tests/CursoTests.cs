using EducaOnline.Core.DomainObjects;

namespace EducaOnline.Conteudo.Domain.Tests
{
    public class CursoTests
    {
        [Fact]
        public void Curso_Validar_ValidacoesDevemRetornarExceptions()
        {

            var ex = Assert.Throws<DomainException>(() =>
                new Curso(Guid.NewGuid(),string.Empty, "Descricao", string.Empty, string.Empty, string.Empty, string.Empty,true,DateTime.Now, new Categoria(string.Empty, 0))
            );

            Assert.Equal("O campo Nome do Curso não pode estar vazio", ex.Message);

        }
    }
}
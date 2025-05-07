using EducaOnline.Core.DomainObjects;

namespace EducaOnline.Conteudo.Domain
{
    public class Curso : Entity, IAggregateRoot
    {
        public Guid CategoriaId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string ImagemUrl { get; private set; }
        public string VideoUrl { get; private set; }
        public string Url { get; private set; }
        public string Autor { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadatro { get; private set; }
        public Categoria Categoria { get; private set; }


        //EF
        protected Curso() { }

        public Curso(Guid categoriaId, string nome, string descricao, string imagemUrl, string videoUrl, string url, string autor, bool ativo, DateTime dataCadatro, Categoria categoria)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            ImagemUrl = imagemUrl;
            VideoUrl = videoUrl;
            Url = url;
            Autor = autor;
            Ativo = ativo;
            DataCadatro = dataCadatro;

            Validar();
        }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void AlterarCagetoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do Curso não pode estar vazio");
            Validacoes.ValidarSeVazio(Descricao, "O campo Descricao do Curso não pode estar vazio");
            //Validacoes.ValidarSeIgual(CategoriaId, Guid.Empty, "O campo CategoriaId do Curso não pode estar vazio");
        }
    }


}

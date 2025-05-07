using System.ComponentModel.DataAnnotations;

namespace EducaOnline.Conteudo.Application.ViewModels
{
    public class CursoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ImagemUrl { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string VideoUrl { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Url { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCadatro { get;   set; }
        public IEnumerable<CategoriaViewModel> Categorias { get; set; }

    }
}

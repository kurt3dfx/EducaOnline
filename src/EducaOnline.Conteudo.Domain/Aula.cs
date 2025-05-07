using EducaOnline.Core.DomainObjects;

namespace EducaOnline.Conteudo.Domain
{
    public class Aula : Entity
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        

        public ICollection<ConteudoProgramatico>ConteudosProgramatico { get; private set; }

        protected Aula() { }

        public Aula(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            //ConteudoProgramaticoId = conteudoProgramaticoId;
        }
    }


}

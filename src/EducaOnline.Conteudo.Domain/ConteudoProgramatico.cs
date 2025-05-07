using EducaOnline.Core.DomainObjects;

namespace EducaOnline.Conteudo.Domain
{
    public class ConteudoProgramatico : Entity
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int Ordem { get; private set; }

        //EF Relationship
        public Guid AulaId { get; private set; }

        public Aula Aula { get; private set; }


        //EF Constructor
        protected ConteudoProgramatico() { }

        public ConteudoProgramatico(string nome, string descricao, int ordem, Guid aulaid)
        {
            Nome = nome; 
            Descricao = descricao; 
            Ordem = ordem;
            AulaId = aulaid;
        }
    }
}

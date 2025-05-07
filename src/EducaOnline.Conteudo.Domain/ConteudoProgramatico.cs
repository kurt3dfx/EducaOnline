using EducaOnline.Core.DomainObjects;

namespace EducaOnline.Conteudo.Domain
{
    public class ConteudoProgramatico : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Ordem { get; set; }

        //EF Relationship
        public Guid AulaId { get; set; }

        public Aula Aula { get; set; }


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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EducaOnline.Conteudo.Domain;


namespace EducaOnline.Conteudo.Data.Mappings
{
    public class AulaMapping : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(a => a.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.HasMany(a => a.ConteudosProgramatico)
                .WithOne(cp => cp.Aula)
                .HasForeignKey(cp => cp.AulaId);

            builder.ToTable("Aulas");
        }
    }
}

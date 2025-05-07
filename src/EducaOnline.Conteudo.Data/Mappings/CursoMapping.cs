using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EducaOnline.Conteudo.Domain;


namespace EducaOnline.Conteudo.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {            
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");
            builder.Property(c => c.ImagemUrl)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(c => c.VideoUrl)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property<string>(c => c.Url);
            builder.Property(c => c.Autor)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.ToTable("Cursos");
        }
    }
}

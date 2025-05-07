using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EducaOnline.Conteudo.Domain;


namespace EducaOnline.Conteudo.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            // 1: N => Categorias : Produtos
            builder.HasMany(c => c.Cursos)
                .WithOne(c => c.Categoria)
                .HasForeignKey(c => c.CategoriaId);

            builder.ToTable("Categorias");
        }
    }
}

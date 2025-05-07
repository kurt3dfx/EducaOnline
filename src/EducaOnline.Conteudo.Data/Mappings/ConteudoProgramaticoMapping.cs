using EducaOnline.Conteudo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaOnline.Conteudo.Data.Mappings
{
    internal class ConteudoProgramaticoMapping : IEntityTypeConfiguration<ConteudoProgramatico>
    {
        public void Configure(EntityTypeBuilder<ConteudoProgramatico> builder)
        {
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");


            // 1: N => ConteudoProgramatico : Aulas
            builder.HasOne(cp => cp.Aula)
                .WithMany(a => a.ConteudosProgramatico)
                .HasForeignKey(cp => cp.AulaId);

            builder.ToTable("ConteudosProgramaticos");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class UnidadeAtendimentoConfiguration : IEntityTypeConfiguration<UnidadeAtendimento>
    {
        public void Configure(EntityTypeBuilder<UnidadeAtendimento> builder)
        {
            builder.ToTable("UnidadeAtendimento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Tipo)
                   .IsRequired();

            builder.Property(x => x.Nome)
                .HasMaxLength(150);
        }
    }
}
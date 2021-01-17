using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class ProcedimentoConfiguration : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.ToTable("Procedimento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
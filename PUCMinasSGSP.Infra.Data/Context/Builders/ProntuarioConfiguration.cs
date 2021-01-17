using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class ProntuarioConfiguration : IEntityTypeConfiguration<Prontuario>
    {
        public void Configure(EntityTypeBuilder<Prontuario> builder)
        {
            builder.ToTable("Prontuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TipoSanguinio)
                   .HasMaxLength(10);

            builder.Property(x => x.TipoSanguinio)
                   .HasMaxLength(5);
        }
    }
}
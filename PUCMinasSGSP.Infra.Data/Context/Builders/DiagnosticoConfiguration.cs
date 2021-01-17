using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.ToTable("Diagnostico");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Prontuario)
                  .WithMany(x => x.Diagnosticos)
                  .HasForeignKey(x => x.IdProntuario);

            builder.HasOne(x => x.UnidadeAtendimento)
                 .WithMany(x => x.Diagnosticos)
                 .HasForeignKey(x => x.IdUnidadeAtendimento);
        }
    }
}
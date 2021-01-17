using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class DetalhesProntuarioConfiguration : IEntityTypeConfiguration<DetalhesProntuario>
    {
        public void Configure(EntityTypeBuilder<DetalhesProntuario> builder)
        {
            builder.ToTable("DetalhesProntuario");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Prontuario)
                   .WithMany(x => x.DetalhesProntuario)
                   .HasForeignKey(x => x.IdProntuario);

            builder.HasOne(x => x.Internacao)
                   .WithMany(x => x.DetalhesProntuario)
                   .HasForeignKey(x => x.IdInternacao);

            builder.HasOne(x => x.Diagnostico)
                  .WithMany(x => x.DetalhesProntuario)
                  .HasForeignKey(x => x.IdDiagnostico);

            builder.HasOne(x => x.Procedimento)
                  .WithMany(x => x.DetalhesProntuario)
                  .HasForeignKey(x => x.IdProcedimento);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class EspecialidadeFuncionarioConfiguration : IEntityTypeConfiguration<EspecialidadeFuncionario>
    {
        public void Configure(EntityTypeBuilder<EspecialidadeFuncionario> builder)
        {
            builder.ToTable("EspecialidadeFuncionario");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Funcionario)
                .WithMany(x => x.Especialidades)
                .HasForeignKey(x => x.IdFuncionario)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Especialidade)
                .WithMany(x => x.Funcionarios)
                .HasForeignKey(x => x.IdEspecialidade)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
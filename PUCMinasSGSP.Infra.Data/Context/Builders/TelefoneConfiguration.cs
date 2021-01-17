using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    internal class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("Telefone");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Tipo)
                   .IsRequired();

            builder.Property(x => x.DDI)
                .HasMaxLength(4);

            builder.Property(x => x.DDD)
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(x => x.Complemento)
                .HasMaxLength(50);

            builder.HasOne(x => x.Pessoa)
                .WithMany(x => x.Telefones)
                .HasForeignKey(x => x.IdPessoa)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
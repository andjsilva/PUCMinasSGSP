using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Tipo)
                   .IsRequired();

            builder.Property(x => x.IdFabricante)
                   .HasMaxLength(30);

            builder.Property(x => x.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Fabricante)
                   .HasMaxLength(100);
        }
    }
}
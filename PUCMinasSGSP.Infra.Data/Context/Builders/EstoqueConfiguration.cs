using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque");

            builder.HasKey(x => new { x.IdProduto, x.IdUnidadeAtendimento });

            builder.HasOne(x => x.Produto)
                   .WithMany(x => x.Estoque)
                   .HasForeignKey(x => x.IdProduto);

            builder.HasOne(x => x.UnidadeAtendimento)
                .WithMany(x => x.Estoque)
                .HasForeignKey(x => x.IdUnidadeAtendimento);
        }
    }
}
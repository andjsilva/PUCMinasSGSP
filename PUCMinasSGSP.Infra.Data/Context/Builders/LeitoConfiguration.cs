using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class LeitoConfiguration : IEntityTypeConfiguration<Leito>
    {
        public void Configure(EntityTypeBuilder<Leito> builder)
        {
            builder.ToTable("Leito");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Localizacao)
                 .IsRequired()
                 .HasMaxLength(30);

            builder.HasOne(x => x.UnidadeAtendimento)
                  .WithMany(x => x.Leitos)
                  .HasForeignKey(x => x.IdUnidadeAtendimento);
        }
    }
}

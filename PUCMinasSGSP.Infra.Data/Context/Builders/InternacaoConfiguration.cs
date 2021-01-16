using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class InternacaoConfiguration : IEntityTypeConfiguration<Internacao>
    {
        public void Configure(EntityTypeBuilder<Internacao> builder)
        {
            builder.ToTable("Internacao");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Prontuario)
                   .WithMany(x => x.Internacoes)
                   .HasForeignKey(x => x.IdProntuario);

            builder.HasOne(x => x.Leito)
                   .WithMany(x => x.Internacoes)
                   .HasForeignKey(x => x.IdLeito);

            builder.HasOne(x => x.Medico)
                  .WithMany(x => x.Internacoes)
                  .HasForeignKey(x => x.IdMedico);
        }
    }
}

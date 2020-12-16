using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("Documento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Tipo)
                   .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(x => x.Pessoa)
                .WithMany(x => x.Documentos)
                .HasForeignKey(x => x.IdPessoa)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}

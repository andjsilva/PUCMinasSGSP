using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {

            builder.ToTable("Email");

            builder.Property(x => x.Tipo)
                   .IsRequired();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Endereco)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.HasOne(x => x.Pessoa)
               .WithMany(x => x.Emails)
               .HasForeignKey(x => x.IdPessoa)
               .OnDelete(DeleteBehavior.Cascade);


        }
    }
}

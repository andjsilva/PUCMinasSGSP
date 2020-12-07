using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(x => x.IdUsuario)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Senha)
             .HasMaxLength(80)
             .IsRequired();

            builder.Property(x => x.Email)
             .HasMaxLength(255)
             .IsRequired();


        }
    }
}

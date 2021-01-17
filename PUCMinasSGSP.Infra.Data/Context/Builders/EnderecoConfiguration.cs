using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.Property(x => x.Tipo)
                   .IsRequired();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro)
              .HasMaxLength(150)
              .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(30);

            builder.Property(x => x.Complemento)
           .HasMaxLength(50);

            builder.Property(x => x.Cep)
                .HasMaxLength(8);

            builder.Property(x => x.Bairro)
                .HasMaxLength(80);

            builder.Property(x => x.Municipio)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Estado)
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasMaxLength(30);

            builder.HasOne(x => x.Pessoa)
                .WithMany(x => x.Enderecos)
                .HasForeignKey(x => x.IdPessoa)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.UnidadeAtendimento)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Endereco>(x => x.IdUnidadeAtendimento)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
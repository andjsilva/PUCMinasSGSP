using System;
using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context.Builders;

namespace PUCMinasSGSP.Infra.Data.Context
{
    public class SGSPDbContext : DbContext
    {
        public SGSPDbContext(DbContextOptions<SGSPDbContext> options) : base(options) { }

        public DbSet<Email> Email {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            
            modelBuilder.ApplyConfiguration(new EmailConfiguration());

            modelBuilder.ApplyConfiguration(new TelefoneConfiguration());

            modelBuilder.ApplyConfiguration(new EnderecoConfiguation());

         


        }

    }
}

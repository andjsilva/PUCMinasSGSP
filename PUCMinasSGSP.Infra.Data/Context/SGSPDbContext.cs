using System;
using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context.Builders;

namespace PUCMinasSGSP.Infra.Data.Context
{
    public class SGSPDbContext : DbContext
    {
        public SGSPDbContext(DbContextOptions<SGSPDbContext> options) : base(options) { }

        public DbSet<Agenda> Agenda { get; set; }

        public DbSet<Cargo> Cargo { get; set; }

        public DbSet<Documento> Documento { get; set; }

        public DbSet<Email> Email { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Especialidade> Especialidade { get; set; }

        public DbSet<EspecialidadeFuncionario> EspecialidadeFuncionario { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Telefone> Telefone { get; set; }

        public DbSet<UnidadeAtendimento> UnidadeAtendimento { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AgendaConfiguration());

            modelBuilder.ApplyConfiguration(new CargoConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentoConfiguration());

            modelBuilder.ApplyConfiguration(new EmailConfiguration());

            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            modelBuilder.ApplyConfiguration(new EspecialidadeConfiguration());

            modelBuilder.ApplyConfiguration(new EspecialidadeFuncionarioConfiguration());

            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());

            modelBuilder.ApplyConfiguration(new PacienteConfiguration());

            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            
            modelBuilder.ApplyConfiguration(new TelefoneConfiguration());

            modelBuilder.ApplyConfiguration(new UnidadeAtendimentoConfiguration());

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

        }

    }
}

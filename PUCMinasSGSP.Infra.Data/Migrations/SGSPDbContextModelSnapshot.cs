﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Migrations
{
    [DbContext(typeof(SGSPContext))]
    partial class SGSPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Agenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Entrada")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdFuncionario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPaciente")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Saida")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFuncionario");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Documento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPessoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("IdPessoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<Guid?>("IdPessoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUnidadeAtendimento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<double>("Longetude")
                        .HasColumnType("float");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Numero")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.HasIndex("IdUnidadeAtendimento")
                        .IsUnique()
                        .HasFilter("[IdUnidadeAtendimento] IS NOT NULL");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Especialidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.EspecialidadeFuncionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEspecialidade")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdFuncionario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdEspecialidade");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("EspecialidadeFuncionario");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Telefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("DDI")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<Guid?>("IdPessoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUnidadeAtendimento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<bool>("Recado")
                        .HasColumnType("bit");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid?>("UnidadeAtendimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.HasIndex("UnidadeAtendimentoId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.UnidadeAtendimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UnidadeAtendimento");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Funcionario", b =>
                {
                    b.HasBaseType("PUCMinasSGSP.Domain.Entities.Pessoa");

                    b.Property<DateTime>("Admissao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCargo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasIndex("IdCargo");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Paciente", b =>
                {
                    b.HasBaseType("PUCMinasSGSP.Domain.Entities.Pessoa");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Usuario", b =>
                {
                    b.HasBaseType("PUCMinasSGSP.Domain.Entities.Pessoa");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Agenda", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany("Agendas")
                        .HasForeignKey("IdFuncionario");

                    b.HasOne("PUCMinasSGSP.Domain.Entities.Paciente", "Paciente")
                        .WithMany("Agendas")
                        .HasForeignKey("IdPaciente");

                    b.Navigation("Funcionario");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Documento", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Documentos")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Email", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Emails")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PUCMinasSGSP.Domain.Entities.UnidadeAtendimento", "UnidadeAtendimento")
                        .WithOne("Endereco")
                        .HasForeignKey("PUCMinasSGSP.Domain.Entities.Endereco", "IdUnidadeAtendimento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Pessoa");

                    b.Navigation("UnidadeAtendimento");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.EspecialidadeFuncionario", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Especialidade", "Especialidade")
                        .WithMany("Funcionarios")
                        .HasForeignKey("IdEspecialidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PUCMinasSGSP.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany("Especialidades")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Telefone", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PUCMinasSGSP.Domain.Entities.UnidadeAtendimento", "UnidadeAtendimento")
                        .WithMany("Telefones")
                        .HasForeignKey("UnidadeAtendimentoId");

                    b.Navigation("Pessoa");

                    b.Navigation("UnidadeAtendimento");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Funcionario", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("PUCMinasSGSP.Domain.Entities.Funcionario", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("PUCMinasSGSP.Domain.Entities.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("IdCargo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Paciente", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("PUCMinasSGSP.Domain.Entities.Paciente", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("PUCMinasSGSP.Domain.Entities.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("PUCMinasSGSP.Domain.Entities.Usuario", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Cargo", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Especialidade", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Pessoa", b =>
                {
                    b.Navigation("Documentos");

                    b.Navigation("Emails");

                    b.Navigation("Enderecos");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.UnidadeAtendimento", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Funcionario", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("Especialidades");
                });

            modelBuilder.Entity("PUCMinasSGSP.Domain.Entities.Paciente", b =>
                {
                    b.Navigation("Agendas");
                });
#pragma warning restore 612, 618
        }
    }
}

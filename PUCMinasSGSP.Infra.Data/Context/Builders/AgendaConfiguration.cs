﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Infra.Data.Context.Builders
{
    public class AgendaConfiguration : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Funcionario)
                .WithMany(x => x.Agendas)
                .HasForeignKey(x => x.IdFuncionario);

            builder.HasOne(x => x.Paciente)
                .WithMany(x => x.Agendas)
                .HasForeignKey(x => x.IdPaciente);


        }
    }
}
﻿using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperPaciente
    {
        Paciente MapperDtoToEntity(PacienteDto pacienteDto);

        IEnumerable<PacienteDto> MapperListPacientesDto(IEnumerable<Paciente> pacientes);

        PacienteDto MapperEntityToDto(Paciente paciente);

    }
}

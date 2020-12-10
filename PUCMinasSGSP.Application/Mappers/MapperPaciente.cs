using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperPaciente : IMapperPaciente
    {

        public Paciente MapperDtoToEntity(PacienteDto pacienteDto)
        {
            var paciente = new Paciente()
            {
                Id = pacienteDto.Id,
                Nome = pacienteDto.Nome,
                Status = pacienteDto.Status
            };

            return paciente;

        }

        public PacienteDto MapperEntityToDto(Paciente paciente)
        {
            var pacienteDto = new PacienteDto()
            {
                Id = paciente.Id,
                Nome = paciente.Nome,
                Status = paciente.Status
            };

            return pacienteDto;
        }

        public IEnumerable<PacienteDto> MapperListPacientesDto(IEnumerable<Paciente> pacientes)
        {
            var dto = pacientes.Select(c => new PacienteDto { Id = c.Id,
                                                              Nome = c.Nome,
                                                              Status = c.Status} );
            return dto;
        }
    }
}

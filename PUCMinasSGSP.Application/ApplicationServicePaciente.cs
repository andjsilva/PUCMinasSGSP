using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServicePaciente : IApplicationServicePaciente
    {
        private readonly IServicePaciente servicePaciente;
        private readonly IMapperPaciente mapperPaciente;

        public ApplicationServicePaciente(IServicePaciente servicePaciente,
                                          IMapperPaciente mapperPaciente)
        {
            this.servicePaciente = servicePaciente;
            this.mapperPaciente = mapperPaciente;
        }

        public void Add(PacienteDto pacienteDto)
        {
            var paciente = mapperPaciente.MapperDtoToEntity(pacienteDto);
            servicePaciente.Add(paciente);
        }

        public IEnumerable<PacienteDto> GetAll()
        {
            var pacientes = servicePaciente.GetAll();

            return mapperPaciente.MapperListPacientesDto(pacientes);

        }

        public PacienteDto GetById(Guid id)
        {
            var paciente = servicePaciente.GetById(id);
            return mapperPaciente.MapperEntityToDto(paciente);
        }

        public void Remove(PacienteDto pacienteDto)
        {
            var paciente = mapperPaciente.MapperDtoToEntity(pacienteDto);
            servicePaciente.Remove(paciente);
        }

        public void Update(PacienteDto pacienteDto)
        {
            var paciente = mapperPaciente.MapperDtoToEntity(pacienteDto);
            servicePaciente.Update(paciente);
        }
    }
}

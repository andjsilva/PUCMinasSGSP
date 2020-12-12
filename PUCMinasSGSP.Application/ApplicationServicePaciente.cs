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
            var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);
            this.servicePaciente.Add(paciente);
        }

        public IEnumerable<PacienteDto> GetAll()
        {
            var pacientes = this.servicePaciente.GetAll();

            return this.mapperPaciente.MapperListPacientesDto(pacientes);

        }

        public PacienteDto GetById(Guid id)
        {
            var paciente = this.servicePaciente.GetById(id);
            return this.mapperPaciente.MapperEntityToDto(paciente);
        }

        public void Remove(PacienteDto pacienteDto)
        {
            var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);
            this.servicePaciente.Remove(paciente);
        }

        public void Update(PacienteDto pacienteDto)
        {
            var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);
            this.servicePaciente.Update(paciente);
        }
    }
}

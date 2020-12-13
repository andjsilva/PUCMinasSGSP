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

        public PacienteDto Add(PacienteDto pacienteDto)
        {
            var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);
            var result = this.servicePaciente.Add(paciente);
            return this.mapperPaciente.MapperEntityToDto(result);
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

        public bool Remove(Guid id)
        {
            var paciente = this.servicePaciente.GetById(id);

            if (paciente == null)
                return false;

            this.servicePaciente.Remove(paciente);
            return true;
         
        }

        public PacienteDto Update(Guid id, PacienteDto pacienteDto)
        {
            var result = this.servicePaciente.GetById(id);

            if (result != null)
            {
                pacienteDto.Id = result.Id;

                var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);

                this.servicePaciente.Update(paciente);

                return this.GetById(paciente.Id);
            }
            else
            {
                return new PacienteDto();
            }         

        }
    }
}

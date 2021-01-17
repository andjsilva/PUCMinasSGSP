using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<PacienteDto> AddAsync(PacienteDto pacienteDto)
        {
            var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);
            var result = await this.servicePaciente.AddAsync(paciente);
            return this.mapperPaciente.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<PacienteDto>> GetAllAsync()
        {
            var pacientes = await this.servicePaciente.GetAllAsync();

            return this.mapperPaciente.MapperListPacientesDto(pacientes);
        }

        public async Task<PacienteDto> GetByIdAsync(Guid id)
        {
            var paciente = await this.servicePaciente.GetByIdAsync(id);
            return this.mapperPaciente.MapperEntityToDto(paciente);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var paciente = await this.servicePaciente.GetByIdAsync(id);

            if (paciente == null)
                return false;

            await this.servicePaciente.RemoveAsync(paciente);
            return true;
        }

        public async Task<PacienteDto> UpdateAsync(Guid id, PacienteDto pacienteDto)
        {
            var result = await this.servicePaciente.GetByIdAsync(id);

            if (result != null)
            {
                pacienteDto.Id = result.Id;

                var paciente = this.mapperPaciente.MapperDtoToEntity(pacienteDto);

                await this.servicePaciente.UpdateAsync(paciente);

                return await this.GetByIdAsync(paciente.Id);
            }
            else
            {
                return new PacienteDto();
            }
        }
    }
}
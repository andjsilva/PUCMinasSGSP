using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceDiagnostico : IApplicationServiceDiagnostico
    {
        private readonly IServiceDiagnostico serviceDiagnostico;
        private readonly IMapperDiagnostico mapperDiagnostico;

        public ApplicationServiceDiagnostico(IServiceDiagnostico serviceDiagnostico,
                                          IMapperDiagnostico mapperDiagnostico)
        {
            this.serviceDiagnostico = serviceDiagnostico;
            this.mapperDiagnostico = mapperDiagnostico;
        }

        public async Task<DiagnosticoDto> AddAsync(DiagnosticoDto diagnosticoDto)
        {
            var diagnostico = this.mapperDiagnostico.MapperDtoToEntity(diagnosticoDto);
            var result = await this.serviceDiagnostico.AddAsync(diagnostico);
            return this.mapperDiagnostico.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<DiagnosticoDto>> GetAllAsync()
        {
            var diagnosticos = await this.serviceDiagnostico.GetAllAsync();
            return this.mapperDiagnostico.MapperListDiagnosticosDto(diagnosticos);
        }

        public async Task<DiagnosticoDto> GetByIdAsync(Guid id)
        {
            var diagnostico = await this.serviceDiagnostico.GetByIdAsync(id);
            return this.mapperDiagnostico.MapperEntityToDto(diagnostico);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var diagnostico = await this.serviceDiagnostico.GetByIdAsync(id);

            if (diagnostico == null)
                return false;

            await this.serviceDiagnostico.RemoveAsync(diagnostico);
            return true;
        }

        public async Task<DiagnosticoDto> UpdateAsync(Guid id, DiagnosticoDto diagnosticoDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                diagnosticoDto.Id = result.Id;

                var diagnostico = this.mapperDiagnostico.MapperDtoToEntity(diagnosticoDto);

                await this.serviceDiagnostico.UpdateAsync(diagnostico);

                return await this.GetByIdAsync(diagnostico.Id);
            }
            else
            {
                return new DiagnosticoDto();
            }
        }
    }
}
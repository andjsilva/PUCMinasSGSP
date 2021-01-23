using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceProntuario : IApplicationServiceProntuario
    {
        private readonly IServiceProntuario serviceProntuario;
        private readonly IMapperProntuario mapperProntuario;

        public ApplicationServiceProntuario(IServiceProntuario serviceProntuario,
                                          IMapperProntuario mapperProntuario)
        {
            this.serviceProntuario = serviceProntuario;
            this.mapperProntuario = mapperProntuario;
        }

        public async Task<ProntuarioDto> AddAsync(ProntuarioDto prontuarioDto)
        {
            var prontuario = this.mapperProntuario.MapperDtoToEntity(prontuarioDto);
            var result = await this.serviceProntuario.AddAsync(prontuario);
            return this.mapperProntuario.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<ProntuarioDto>> GetAllAsync()
        {
            var prontuarios = await this.serviceProntuario.GetAllAsync();
            return this.mapperProntuario.MapperListProntuariosDto(prontuarios);
        }

        public async Task<ProntuarioDto> GetByIdAsync(Guid id)
        {
            var prontuario = await this.serviceProntuario.GetByIdAsync(id);
            return this.mapperProntuario.MapperEntityToDto(prontuario);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var prontuario = await this.serviceProntuario.GetByIdAsync(id);

            if (prontuario == null)
                return false;

            await this.serviceProntuario.RemoveAsync(prontuario);
            return true;
        }

        public async Task<ProntuarioDto> UpdateAsync(Guid id, ProntuarioDto prontuarioDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                prontuarioDto.Id = result.Id;

                var prontuario = this.mapperProntuario.MapperDtoToEntity(prontuarioDto);

                await this.serviceProntuario.UpdateAsync(prontuario);

                return await this.GetByIdAsync(prontuario.Id);
            }
            else
            {
                return new ProntuarioDto();
            }
        }
    }
}
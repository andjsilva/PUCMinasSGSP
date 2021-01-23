using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceLeito : IApplicationServiceLeito
    {
        private readonly IServiceLeito serviceLeito;
        private readonly IMapperLeito mapperLeito;

        public ApplicationServiceLeito(IServiceLeito serviceLeito,
                                          IMapperLeito mapperLeito)
        {
            this.serviceLeito = serviceLeito;
            this.mapperLeito = mapperLeito;
        }

        public async Task<LeitoDto> AddAsync(LeitoDto leitoDto)
        {
            var leito = this.mapperLeito.MapperDtoToEntity(leitoDto);
            var result = await this.serviceLeito.AddAsync(leito);
            return this.mapperLeito.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<LeitoDto>> GetAllAsync()
        {
            var leitos = await this.serviceLeito.GetAllAsync();
            return this.mapperLeito.MapperListLeitosDto(leitos);
        }

        public async Task<LeitoDto> GetByIdAsync(Guid id)
        {
            var leito = await this.serviceLeito.GetByIdAsync(id);
            return this.mapperLeito.MapperEntityToDto(leito);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var leito = await this.serviceLeito.GetByIdAsync(id);

            if (leito == null)
                return false;

            await this.serviceLeito.RemoveAsync(leito);
            return true;
        }

        public async Task<LeitoDto> UpdateAsync(Guid id, LeitoDto leitoDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                leitoDto.Id = result.Id;

                var leito = this.mapperLeito.MapperDtoToEntity(leitoDto);

                await this.serviceLeito.UpdateAsync(leito);

                return await this.GetByIdAsync(leito.Id);
            }
            else
            {
                return new LeitoDto();
            }
        }
    }
}
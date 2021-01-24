using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceDetalhesProntuario : IApplicationServiceDetalhesProntuario
    {
        private readonly IServiceDetalhesProntuario serviceDetalhesProntuario;
        private readonly IMapperDetalhesProntuario mapperDetalhesProntuario;

        public ApplicationServiceDetalhesProntuario(IServiceDetalhesProntuario serviceDetalhesProntuario,
                                          IMapperDetalhesProntuario mapperDetalhesProntuario)
        {
            this.serviceDetalhesProntuario = serviceDetalhesProntuario;
            this.mapperDetalhesProntuario = mapperDetalhesProntuario;
        }

        public async Task<DetalhesProntuarioDto> AddAsync(DetalhesProntuarioDto detalhesProntuarioDto)
        {
            var detalhesProntuario = this.mapperDetalhesProntuario.MapperDtoToEntity(detalhesProntuarioDto);
            var result = await this.serviceDetalhesProntuario.AddAsync(detalhesProntuario);
            return this.mapperDetalhesProntuario.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<DetalhesProntuarioDto>> GetAllAsync()
        {
            var detalhesProntuarios = await this.serviceDetalhesProntuario.GetAllAsync();
            return this.mapperDetalhesProntuario.MapperListDetalhesProntuariosDto(detalhesProntuarios);
        }

        public async Task<DetalhesProntuarioDto> GetByIdAsync(Guid id)
        {
            var detalhesProntuario = await this.serviceDetalhesProntuario.GetByIdAsync(id);
            return this.mapperDetalhesProntuario.MapperEntityToDto(detalhesProntuario);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var detalhesProntuario = await this.serviceDetalhesProntuario.GetByIdAsync(id);

            if (detalhesProntuario == null)
                return false;

            await this.serviceDetalhesProntuario.RemoveAsync(detalhesProntuario);
            return true;
        }

        public async Task<DetalhesProntuarioDto> UpdateAsync(Guid id, DetalhesProntuarioDto detalhesProntuarioDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                detalhesProntuarioDto.Id = result.Id;

                var detalhesProntuario = this.mapperDetalhesProntuario.MapperDtoToEntity(detalhesProntuarioDto);

                await this.serviceDetalhesProntuario.UpdateAsync(detalhesProntuario);

                return await this.GetByIdAsync(detalhesProntuario.Id);
            }
            else
            {
                return new DetalhesProntuarioDto();
            }
        }
    }
}
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceEndereco : IApplicationServiceEndereco
    {
        private readonly IServiceEndereco serviceEndereco;
        private readonly IMapperEndereco mapperEndereco;

        public ApplicationServiceEndereco(IServiceEndereco serviceEndereco,
                                          IMapperEndereco mapperEndereco)
        {
            this.serviceEndereco = serviceEndereco;
            this.mapperEndereco = mapperEndereco;
        }

        public async Task<EnderecoDto> AddAsync(EnderecoDto enderecoDto)
        {
            var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);
            var result = await this.serviceEndereco.AddAsync(endereco);
            return this.mapperEndereco.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<EnderecoDto>> GetAllAsync()
        {
            var enderecos = await this.serviceEndereco.GetAllAsync();

            return this.mapperEndereco.MapperListEnderecosDto(enderecos);

        }

        public async Task<EnderecoDto> GetByIdAsync(Guid id)
        {
            var endereco = await this.serviceEndereco.GetByIdAsync(id);
            return this.mapperEndereco.MapperEntityToDto(endereco);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var endereco = await this.serviceEndereco.GetByIdAsync(id);

            if (endereco == null)
                return false;

            await this.serviceEndereco.RemoveAsync(endereco);
            return true;

        }

        public async Task<EnderecoDto> UpdateAsync(Guid id, EnderecoDto enderecoDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                enderecoDto.Id = result.Id;

                var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);

                await this.serviceEndereco.UpdateAsync(endereco);

                return await this.GetByIdAsync(endereco.Id);
            }
            else
            {
                return new EnderecoDto();
            }         

        }
    }
}

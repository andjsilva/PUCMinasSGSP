using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceEstoque : IApplicationServiceEstoque
    {
        private readonly IServiceEstoque serviceEstoque;
        private readonly IMapperEstoque mapperEstoque;

        public ApplicationServiceEstoque(IServiceEstoque serviceEstoque,
                                          IMapperEstoque mapperEstoque)
        {
            this.serviceEstoque = serviceEstoque;
            this.mapperEstoque = mapperEstoque;
        }

        public async Task<EstoqueDto> AddAsync(EstoqueDto estoqueDto)
        {
            var estoque = this.mapperEstoque.MapperDtoToEntity(estoqueDto);
            var result = await this.serviceEstoque.AddAsync(estoque);
            return this.mapperEstoque.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<EstoqueDto>> GetAllAsync()
        {
            var estoques = await this.serviceEstoque.GetAllAsync();
            return this.mapperEstoque.MapperListEstoquesDto(estoques);
        }

        public async Task<EstoqueDto> GetByIdAsync(Guid id)
        {
            var estoque = await this.serviceEstoque.GetByIdAsync(id);
            return this.mapperEstoque.MapperEntityToDto(estoque);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var estoque = await this.serviceEstoque.GetByIdAsync(id);

            if (estoque == null)
                return false;

            await this.serviceEstoque.RemoveAsync(estoque);
            return true;
        }

        public async Task<EstoqueDto> UpdateAsync(Guid id, EstoqueDto estoqueDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                estoqueDto.Id = result.Id;

                var estoque = this.mapperEstoque.MapperDtoToEntity(estoqueDto);

                await this.serviceEstoque.UpdateAsync(estoque);

                return await this.GetByIdAsync(estoque.Id);
            }
            else
            {
                return new EstoqueDto();
            }
        }
    }
}
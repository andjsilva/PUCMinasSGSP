using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto,
                                          IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public async Task<ProdutoDto> AddAsync(ProdutoDto produtoDto)
        {
            var produto = this.mapperProduto.MapperDtoToEntity(produtoDto);
            var result = await this.serviceProduto.AddAsync(produto);
            return this.mapperProduto.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<ProdutoDto>> GetAllAsync()
        {
            var produtos = await this.serviceProduto.GetAllAsync();
            return this.mapperProduto.MapperListProdutosDto(produtos);
        }

        public async Task<ProdutoDto> GetByIdAsync(Guid id)
        {
            var produto = await this.serviceProduto.GetByIdAsync(id);
            return this.mapperProduto.MapperEntityToDto(produto);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var produto = await this.serviceProduto.GetByIdAsync(id);

            if (produto == null)
                return false;

            await this.serviceProduto.RemoveAsync(produto);
            return true;
        }

        public async Task<ProdutoDto> UpdateAsync(Guid id, ProdutoDto produtoDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                produtoDto.Id = result.Id;

                var produto = this.mapperProduto.MapperDtoToEntity(produtoDto);

                await this.serviceProduto.UpdateAsync(produto);

                return await this.GetByIdAsync(produto.Id);
            }
            else
            {
                return new ProdutoDto();
            }
        }
    }
}
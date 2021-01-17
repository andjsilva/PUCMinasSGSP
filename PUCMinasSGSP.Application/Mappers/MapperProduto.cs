using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Tipo = produtoDto.Tipo,
                IdFabricante = produtoDto.IdFabricante,
                Descricao = produtoDto.Descricao,
                Fabricante = produtoDto.Fabricante,
                UnidadeMedida = produtoDto.UnidadeMedida,
                Status = produtoDto.Status
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Tipo = produto.Tipo,
                IdFabricante = produto.IdFabricante,
                Descricao = produto.Descricao,
                Fabricante = produto.Fabricante,
                UnidadeMedida = produto.UnidadeMedida,
                Status = produto.Status
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var produtosDto = produtos.Select(item => new ProdutoDto
            {
                Id = item.Id,
                Tipo = item.Tipo,
                IdFabricante = item.IdFabricante,
                Descricao = item.Descricao,
                Fabricante = item.Fabricante,
                UnidadeMedida = item.UnidadeMedida,
                Status = item.Status
            });
            return produtosDto;
        }
    }
}
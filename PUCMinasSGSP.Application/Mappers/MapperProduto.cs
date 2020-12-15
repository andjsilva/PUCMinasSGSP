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
                Descricao = produtoDto.Descricao,
                UnidadeMedida = produtoDto.UnidadeMedida,
                Quantidade = produtoDto.Quantidade,
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
                Descricao = produto.Descricao,
                UnidadeMedida = produto.UnidadeMedida,
                Quantidade = produto.Quantidade,
                Status = produto.Status
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var produtosDto = produtos.Select(c => new ProdutoDto
            {
                Id = c.Id,
                Tipo = c.Tipo,
                Descricao = c.Descricao,
                UnidadeMedida = c.UnidadeMedida,
                Quantidade = c.Quantidade,
                Status = c.Status
            });
            return produtosDto;
        }
    }
}
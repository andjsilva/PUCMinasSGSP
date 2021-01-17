using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperEstoque : IMapperEstoque
    {
        public Estoque MapperDtoToEntity(EstoqueDto estoqueDto)
        {
            var estoque = new Estoque()
            {
                Id = estoqueDto.Id,
                IdProduto = estoqueDto.IdProduto,
                IdUnidadeAtendimento = estoqueDto.IdUnidadeAtendimento,
                Quantidade = estoqueDto.Quantidade
            };

            return estoque;
        }

        public EstoqueDto MapperEntityToDto(Estoque estoque)
        {
            var estoqueDto = new EstoqueDto()
            {
                Id = estoque.Id,
                IdProduto = estoque.IdProduto,
                IdUnidadeAtendimento = estoque.IdUnidadeAtendimento,
                Quantidade = estoque.Quantidade
            };

            return estoqueDto;
        }

        public IEnumerable<EstoqueDto> MapperListEstoquesDto(IEnumerable<Estoque> estoques)
        {
            var estoquesDto = estoques.Select(item => new EstoqueDto
            {
                Id = item.Id,
                IdProduto = item.IdProduto,
                IdUnidadeAtendimento = item.IdUnidadeAtendimento,
                Quantidade = item.Quantidade
            });
            return estoquesDto;
        }
    }
}
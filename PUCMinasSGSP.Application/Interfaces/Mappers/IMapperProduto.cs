using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto endereco);
    }
}
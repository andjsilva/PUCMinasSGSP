using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperEstoque
    {
        Estoque MapperDtoToEntity(EstoqueDto estoqueDto);

        IEnumerable<EstoqueDto> MapperListEstoquesDto(IEnumerable<Estoque> estoques);

        EstoqueDto MapperEntityToDto(Estoque estoque);
    }
}
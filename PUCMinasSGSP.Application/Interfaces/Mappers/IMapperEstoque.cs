using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperEstoque
    { 
        Estoque MapperDtoToEntity(EstoqueDto estoqueDto);

        IEnumerable<EstoqueDto> MapperListEstoquesDto(IEnumerable<Estoque> estoques);

        EstoqueDto MapperEntityToDto(Estoque estoque);

    }
}

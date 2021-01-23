using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperUnidadeAtendimento
    {
        UnidadeAtendimento MapperDtoToEntity(UnidadeAtendimentoDto unidadeAtendimentoDto);

        IEnumerable<UnidadeAtendimentoDto> MapperListUnidadesAtendimentoDto(IEnumerable<UnidadeAtendimento> unidadesAtendimento);

        UnidadeAtendimentoDto MapperEntityToDto(UnidadeAtendimento unidadeAtendimento);
    }
}
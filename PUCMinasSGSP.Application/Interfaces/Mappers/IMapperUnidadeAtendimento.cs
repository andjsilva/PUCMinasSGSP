using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperUnidadeAtendimento
    {
        UnidadeAtendimento MapperDtoToEntity(UnidadeAtendimentoDto pacienteDto);

        IEnumerable<UnidadeAtendimentoDto> MapperListUnidadesAtendimentoDto(IEnumerable<UnidadeAtendimento> pacientes);

        UnidadeAtendimentoDto MapperEntityToDto(UnidadeAtendimento paciente);
    }
}
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperDiagnostico
    {
        Diagnostico MapperDtoToEntity(DiagnosticoDto diagnosticoDto);

        IEnumerable<DiagnosticoDto> MapperListDiagnosticosDto(IEnumerable<Diagnostico> diagnosticos);

        DiagnosticoDto MapperEntityToDto(Diagnostico diagnostico);
    }
}
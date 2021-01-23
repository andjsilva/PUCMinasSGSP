using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperProntuario
    {
        Prontuario MapperDtoToEntity(ProntuarioDto prontuarioDto);

        IEnumerable<ProntuarioDto> MapperListProntuariosDto(IEnumerable<Prontuario> prontuarios);

        ProntuarioDto MapperEntityToDto(Prontuario prontuario);
    }
}
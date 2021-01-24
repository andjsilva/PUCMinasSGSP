using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperDetalhesProntuario
    {
        DetalhesProntuario MapperDtoToEntity(DetalhesProntuarioDto detalhesProntuarioDto);

        IEnumerable<DetalhesProntuarioDto> MapperListDetalhesProntuariosDto(IEnumerable<DetalhesProntuario> detalhesProntuarios);

        DetalhesProntuarioDto MapperEntityToDto(DetalhesProntuario detalhesProntuario);
    }
}
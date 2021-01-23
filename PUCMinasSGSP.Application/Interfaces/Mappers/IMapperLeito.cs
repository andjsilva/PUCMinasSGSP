using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperLeito
    {
        Leito MapperDtoToEntity(LeitoDto leitoDto);

        IEnumerable<LeitoDto> MapperListLeitosDto(IEnumerable<Leito> leitos);

        LeitoDto MapperEntityToDto(Leito leito);
    }
}
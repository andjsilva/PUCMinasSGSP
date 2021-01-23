using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperTelefone
    {
        Telefone MapperDtoToEntity(TelefoneDto telefoneDto);

        IEnumerable<TelefoneDto> MapperListTelefonesDto(IEnumerable<Telefone> telefones);

        TelefoneDto MapperEntityToDto(Telefone telefone);
    }
}
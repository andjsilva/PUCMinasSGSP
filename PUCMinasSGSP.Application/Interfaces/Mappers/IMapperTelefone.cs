using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperTelefone
    {
        Telefone MapperDtoToEntity(TelefoneDto telefoneDto);

        IEnumerable<TelefoneDto> MapperListTelefonesDto(IEnumerable<Telefone> telefones);

        TelefoneDto MapperEntityToDto(Telefone endereco);

    }
}

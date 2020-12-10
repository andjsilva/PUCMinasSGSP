using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperEndereco
    {
        Endereco MapperDtoToEntity(EnderecoDto enderecoDto);

        IEnumerable<EnderecoDto> MapperListEnderecoDto(IEnumerable<Endereco> enderecos);

        EnderecoDto MapperEntityToDto(Endereco endereco);

    }
}

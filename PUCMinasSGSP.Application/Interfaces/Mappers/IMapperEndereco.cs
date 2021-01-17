using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperEndereco
    {
        Endereco MapperDtoToEntity(EnderecoDto enderecoDto);

        IEnumerable<EnderecoDto> MapperListEnderecosDto(IEnumerable<Endereco> enderecos);

        EnderecoDto MapperEntityToDto(Endereco endereco);
    }
}
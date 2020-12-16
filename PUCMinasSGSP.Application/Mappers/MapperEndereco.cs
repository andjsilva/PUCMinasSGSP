using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperEndereco : IMapperEndereco
    {
        public Endereco MapperDtoToEntity(EnderecoDto enderecoDto)
        {
            var endereco = new Endereco()
            {
                Id = enderecoDto.Id,
                Tipo = enderecoDto.Tipo,
                Logradouro = enderecoDto.Logradouro,
                Numero = enderecoDto.Numero,
                Complemento = enderecoDto.Complemento,
                Cep = enderecoDto.Cep,
                Bairro = enderecoDto.Bairro,
                Municipio = enderecoDto.Municipio,
                Estado = enderecoDto.Estado,
                Latitude = enderecoDto.Latitude,
                Longetude = enderecoDto.Longetude
            };

            return endereco;
        }

        public EnderecoDto MapperEntityToDto(Endereco endereco)
        {
            var enderecoDto = new EnderecoDto()
            {
                Id = endereco.Id,
                Tipo = endereco.Tipo,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Complemento = endereco.Complemento,
                Cep = endereco.Cep,
                Bairro = endereco.Bairro,
                Municipio = endereco.Municipio,
                Estado = endereco.Estado,
                Latitude = endereco.Latitude,
                Longetude = endereco.Longetude
            };

            return enderecoDto;
        }

        public IEnumerable<EnderecoDto> MapperListEnderecosDto(IEnumerable<Endereco> enderecos)
        {
            var enderecosDto = enderecos.Select(item => new EnderecoDto
            {
                Id = item.Id,
                Tipo = item.Tipo,
                Logradouro = item.Logradouro,
                Numero = item.Numero,
                Complemento = item.Complemento,
                Cep = item.Cep,
                Bairro = item.Bairro,
                Municipio = item.Municipio,
                Estado = item.Estado,
                Latitude = item.Latitude,
                Longetude = item.Longetude
            });
            return enderecosDto;
        }
    }
}
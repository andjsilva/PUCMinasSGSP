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
            var Endereco = new Endereco()
            {
                Id = enderecoDto.Id,
                TipoLogradouro = enderecoDto.TipoLogradouro,
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

            return Endereco;
        }

        public EnderecoDto MapperEntityToDto(Endereco endereco)
        {
            var EnderecoDto = new EnderecoDto()
            {
                Id = endereco.Id,
                TipoLogradouro = endereco.TipoLogradouro,
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

            return EnderecoDto;
        }

        public IEnumerable<EnderecoDto> MapperListEnderecosDto(IEnumerable<Endereco> endereco)
        {
            var dto = endereco.Select(c => new EnderecoDto
            {
                Id = c.Id,
                TipoLogradouro = c.TipoLogradouro,
                Logradouro = c.Logradouro,
                Numero = c.Numero,
                Complemento = c.Complemento,
                Cep = c.Cep,
                Bairro = c.Bairro,
                Municipio = c.Municipio,
                Estado = c.Estado,
                Latitude = c.Latitude,
                Longetude = c.Longetude
            });
            return dto;
        }
    }
}
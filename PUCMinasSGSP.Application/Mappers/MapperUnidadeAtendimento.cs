using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperUnidadeAtendimento : IMapperUnidadeAtendimento
    {
        public UnidadeAtendimento MapperDtoToEntity(UnidadeAtendimentoDto unidadeAtendimentoDto)
        {
            var unidadeAtendimento = new UnidadeAtendimento();
            var telefones = new List<Telefone>();

            unidadeAtendimento.Id = unidadeAtendimentoDto.Id;
            unidadeAtendimento.Nome = unidadeAtendimentoDto.Nome;
            unidadeAtendimento.Tipo = unidadeAtendimentoDto.Tipo;

            if (unidadeAtendimento.Endereco != null)
            {
                var endereco = new Endereco()
                {
                    Id = unidadeAtendimentoDto.Endereco.Id,
                    Tipo = unidadeAtendimentoDto.Endereco.Tipo,
                    Logradouro = unidadeAtendimentoDto.Endereco.Logradouro,
                    Numero = unidadeAtendimentoDto.Endereco.Numero,
                    Complemento = unidadeAtendimentoDto.Endereco.Complemento,
                    Cep = unidadeAtendimentoDto.Endereco.Cep,
                    Bairro = unidadeAtendimentoDto.Endereco.Bairro,
                    Municipio = unidadeAtendimentoDto.Endereco.Municipio,
                    Estado = unidadeAtendimentoDto.Endereco.Estado,
                    Latitude = unidadeAtendimentoDto.Endereco.Latitude,
                    Longetude = unidadeAtendimentoDto.Endereco.Longetude
                };

                unidadeAtendimento.Endereco = endereco;
            }

            if (unidadeAtendimento.Telefones != null)
            {
                foreach (var item in unidadeAtendimentoDto.Telefones)
                {
                    var telefone = new Telefone()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        DDI = item.DDI,
                        DDD = item.DDD,
                        Numero = item.Numero,
                        Recado = item.Recado,
                        Complemento = item.Complemento
                    };

                    telefones.Add(telefone);
                }

                unidadeAtendimento.Telefones = telefones;
            }

            return unidadeAtendimento;
        }

        public UnidadeAtendimentoDto MapperEntityToDto(UnidadeAtendimento unidadeAtendimento)
        {
            var unidadeAtendimentoDto = new UnidadeAtendimentoDto();
            var telefonesDto = new List<TelefoneDto>();

            unidadeAtendimentoDto.Id = unidadeAtendimento.Id;
            unidadeAtendimentoDto.Nome = unidadeAtendimento.Nome;
            unidadeAtendimentoDto.Tipo = unidadeAtendimento.Tipo;

            if (unidadeAtendimento.Endereco != null)
            {
                var enderecoDto = new EnderecoDto()
                {
                    Id = unidadeAtendimento.Endereco.Id,
                    Tipo = unidadeAtendimento.Endereco.Tipo,
                    Logradouro = unidadeAtendimento.Endereco.Logradouro,
                    Numero = unidadeAtendimento.Endereco.Numero,
                    Complemento = unidadeAtendimento.Endereco.Complemento,
                    Cep = unidadeAtendimento.Endereco.Cep,
                    Bairro = unidadeAtendimento.Endereco.Bairro,
                    Municipio = unidadeAtendimento.Endereco.Municipio,
                    Estado = unidadeAtendimento.Endereco.Estado,
                    Latitude = unidadeAtendimento.Endereco.Latitude,
                    Longetude = unidadeAtendimento.Endereco.Longetude
                };

                unidadeAtendimentoDto.Endereco = enderecoDto;
            }

            if (unidadeAtendimento.Telefones != null)
            {
                foreach (var item in unidadeAtendimento.Telefones)
                {
                    var telefoneDto = new TelefoneDto()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        DDI = item.DDI,
                        DDD = item.DDD,
                        Numero = item.Numero,
                        Recado = item.Recado,
                        Complemento = item.Complemento
                    };

                    telefonesDto.Add(telefoneDto);
                }

                unidadeAtendimentoDto.Telefones = telefonesDto;
            }

            return unidadeAtendimentoDto;
        }

        public IEnumerable<UnidadeAtendimentoDto> MapperListUnidadesAtendimentoDto(IEnumerable<UnidadeAtendimento> unidadesAtendimento)
        {
            var unidadesAtendimentoDto = new List<UnidadeAtendimentoDto>();

            foreach (var unidadeAtendimento in unidadesAtendimento)
            {
                var unidadeAtendimentoDto = new UnidadeAtendimentoDto();
                var enderecoDto = new EnderecoDto();
                var telefonesDto = new List<TelefoneDto>();

                //Unidade de Atendimento
                unidadeAtendimentoDto.Id = unidadeAtendimento.Id;
                unidadeAtendimentoDto.Tipo = unidadeAtendimento.Tipo;
                unidadeAtendimentoDto.Nome = unidadeAtendimento.Nome;

                //Endereço da Unidade de Atendimento
                if (unidadeAtendimento.Endereco != null)
                {
                    enderecoDto.Id = unidadeAtendimento.Endereco.Id;
                    enderecoDto.Tipo = unidadeAtendimento.Endereco.Tipo;
                    enderecoDto.Numero = unidadeAtendimento.Endereco.Numero;
                    enderecoDto.Complemento = unidadeAtendimento.Endereco.Complemento;
                    enderecoDto.Cep = unidadeAtendimento.Endereco.Cep;
                    enderecoDto.Bairro = unidadeAtendimento.Endereco.Bairro;
                    enderecoDto.Municipio = unidadeAtendimento.Endereco.Municipio;
                    enderecoDto.Estado = unidadeAtendimento.Endereco.Estado;
                    enderecoDto.Latitude = unidadeAtendimento.Endereco.Latitude;
                    enderecoDto.Longetude = unidadeAtendimento.Endereco.Longetude;

                    unidadeAtendimentoDto.Endereco = enderecoDto;
                }

                if (unidadeAtendimento.Telefones != null)
                {
                    //Tefones da Unidade de Atendimento
                    foreach (var telefone in unidadeAtendimento.Telefones)
                    {
                        var telefoneDto = new TelefoneDto();

                        telefoneDto.Id = telefone.Id;
                        telefoneDto.Tipo = telefone.Tipo;
                        telefoneDto.DDI = telefone.DDI;
                        telefoneDto.DDD = telefone.DDD;
                        telefoneDto.Numero = telefone.Numero;
                        telefoneDto.Recado = telefone.Recado;
                        telefoneDto.Complemento = telefone.Complemento;

                        telefonesDto.Add(telefoneDto);
                    }

                    unidadeAtendimentoDto.Telefones = telefonesDto;
                }

                unidadesAtendimentoDto.Add(unidadeAtendimentoDto);
            }

            return unidadesAtendimentoDto;
        }
    }
}
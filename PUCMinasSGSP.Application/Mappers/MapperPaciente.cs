using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperPaciente : IMapperPaciente
    {

        public Paciente MapperDtoToEntity(PacienteDto pacienteDto)
        {
            var paciente = new Paciente();
            var enderecos = new List<Endereco>();
            

            paciente.Id = pacienteDto.Id;
            paciente.Nome = pacienteDto.Nome;
            paciente.Status = pacienteDto.Status;

            if (pacienteDto.Enderecos != null)
            {
                foreach (var item in pacienteDto.Enderecos)
                {

                    var endereco = new Endereco()
                    {
                        Id = item.Id,
                        TipoLogradouro = item.TipoLogradouro,
                        Logradouro = item.Logradouro,
                        Numero = item.Numero,
                        Complemento = item.Complemento,
                        Cep = item.Cep,
                        Bairro = item.Bairro,
                        Municipio = item.Municipio,
                        Estado = item.Estado,
                        Latitude = item.Latitude,
                        Longetude = item.Longetude
                    };

                    enderecos.Add(endereco);
                }

                paciente.Enderecos = enderecos;

            }


            return paciente;

        }

        public PacienteDto MapperEntityToDto(Paciente paciente)
        {
            var pacienteDto = new PacienteDto();
            var enderecosDto = new List<EnderecoDto>();


            pacienteDto.Id = paciente.Id;
            pacienteDto.Nome = paciente.Nome;
            pacienteDto.Status = paciente.Status;

            if (paciente.Enderecos != null)
            {
                foreach (var item in paciente.Enderecos)
                {

                    var enderecoDto = new EnderecoDto()
                    {
                        Id = item.Id,
                        TipoLogradouro = item.TipoLogradouro,
                        Logradouro = item.Logradouro,
                        Numero = item.Numero,
                        Complemento = item.Complemento,
                        Cep = item.Cep,
                        Bairro = item.Bairro,
                        Municipio = item.Municipio,
                        Estado = item.Estado,
                        Latitude = item.Latitude,
                        Longetude = item.Longetude
                    };

                    enderecosDto.Add(enderecoDto);
                }

                pacienteDto.Enderecos = enderecosDto;

            }


            return pacienteDto;
        }

        public IEnumerable<PacienteDto> MapperListPacientesDto(IEnumerable<Paciente> pacientes)
        {
            var dto = pacientes.Select(c => new PacienteDto { Id = c.Id,
                                                              Nome = c.Nome,
                                                              Status = c.Status} );
            return dto;
        }
    }
}

using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperPaciente : IMapperPaciente
    {
        public Paciente MapperDtoToEntity(PacienteDto pacienteDto)
        {
            var paciente = new Paciente();
            var enderecos = new List<Endereco>();
            var telefones = new List<Telefone>();

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
                    };

                    enderecos.Add(endereco);
                }

                paciente.Enderecos = enderecos;
            }

            if (pacienteDto.Telefones != null)
            {
                foreach (var item in pacienteDto.Telefones)
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

                paciente.Telefones = telefones;
            }

            return paciente;
        }

        public PacienteDto MapperEntityToDto(Paciente paciente)
        {
            var pacienteDto = new PacienteDto();
            var enderecosDto = new List<EnderecoDto>();
            var telefonesDto = new List<TelefoneDto>();

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
                    };

                    enderecosDto.Add(enderecoDto);
                }

                pacienteDto.Enderecos = enderecosDto;
            }

            if (paciente.Telefones != null)
            {
                foreach (var item in paciente.Telefones)
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

                pacienteDto.Enderecos = enderecosDto;
            }

            return pacienteDto;
        }

        public IEnumerable<PacienteDto> MapperListPacientesDto(IEnumerable<Paciente> pacientes)
        {
            var pacientesDto = new List<PacienteDto>();

            foreach (var paciente in pacientes)
            {
                var pacienteDto = new PacienteDto();
                var enderecosDto = new List<EnderecoDto>();
                var telefonesDto = new List<TelefoneDto>();

                //Paciente
                pacienteDto.Id = paciente.Id;
                pacienteDto.Nome = paciente.Nome;
                pacienteDto.Status = paciente.Status;

                if (paciente.Enderecos != null)
                {
                    //Endereços do Paciente
                    foreach (var endereco in paciente.Enderecos)
                    {
                        var enderecoDto = new EnderecoDto();

                        enderecoDto.Id = endereco.Id;
                        enderecoDto.Tipo = endereco.Tipo;
                        enderecoDto.Logradouro = endereco.Logradouro;
                        enderecoDto.Numero = endereco.Numero;
                        enderecoDto.Complemento = endereco.Complemento;
                        enderecoDto.Cep = endereco.Cep;
                        enderecoDto.Bairro = endereco.Bairro;
                        enderecoDto.Municipio = endereco.Municipio;
                        enderecoDto.Estado = endereco.Estado;
                        enderecoDto.Latitude = endereco.Latitude;
                        enderecoDto.Longetude = endereco.Longetude;

                        enderecosDto.Add(enderecoDto);
                    }
                    pacienteDto.Enderecos = enderecosDto;
                }

                if (paciente.Telefones != null)
                {
                    //Tefones da Unidade de Atendimento
                    foreach (var telefone in paciente.Telefones)
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

                    pacienteDto.Telefones = telefonesDto;
                }

                pacientesDto.Add(pacienteDto);
            }

            return pacientesDto;
        }
    }
}
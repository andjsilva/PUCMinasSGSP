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
            var prontuario = new Prontuario();
            var documentos = new List<Documento>();
            var enderecos = new List<Endereco>();
            var telefones = new List<Telefone>();
            var emails = new List<Email>();

            paciente.Id = pacienteDto.Id;
            paciente.Nome = pacienteDto.Nome;
            paciente.Tipo = pacienteDto.Tipo;
            paciente.Status = pacienteDto.Status;

            prontuario.Id = pacienteDto.Prontuario.Id;
            prontuario.Peso = pacienteDto.Prontuario.Peso;
            prontuario.Altura = pacienteDto.Prontuario.Altura;
            prontuario.AlergiasMedicacao = pacienteDto.Prontuario.AlergiasMedicacao;
            prontuario.Doencas = pacienteDto.Prontuario.Doencas;

            paciente.Prontuario = prontuario;

            if (pacienteDto.Documentos != null)
            {
                foreach (var item in pacienteDto.Documentos)
                {
                    var documento = new Documento()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        Numero = item.Numero
                    };

                    documentos.Add(documento);
                }

                paciente.Documentos = documentos;
            }

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

            if (pacienteDto.Emails != null)
            {
                foreach (var item in pacienteDto.Emails)
                {
                    var email = new Email()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        Endereco = item.Endereco,
                        Status = item.Status
                    };

                    emails.Add(email);
                }

                paciente.Emails = emails;
            }

            return paciente;
        }

        public PacienteDto MapperEntityToDto(Paciente paciente)
        {
            var pacienteDto = new PacienteDto();
            var documentosDto = new List<DocumentoDto>();
            var enderecosDto = new List<EnderecoDto>();
            var telefonesDto = new List<TelefoneDto>();
            var emailsDto = new List<EmailDto>();

            pacienteDto.Id = paciente.Id;
            pacienteDto.Nome = paciente.Nome;
            pacienteDto.Tipo = paciente.Tipo;
            pacienteDto.Status = paciente.Status;
            pacienteDto.IdProntuario = paciente.IdProntuario;

            if (paciente.Documentos != null)
            {
                foreach (var item in paciente.Documentos)
                {
                    var documentoDto = new DocumentoDto()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        Numero = item.Numero
                    };

                    documentosDto.Add(documentoDto);
                }

                pacienteDto.Documentos = documentosDto;
            }

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

            if (paciente.Emails != null)
            {
                foreach (var item in paciente.Emails)
                {
                    var emailDto = new EmailDto()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        Endereco = item.Endereco,
                        Status = item.Status
                    };

                    emailsDto.Add(emailDto);
                }

                pacienteDto.Emails = emailsDto;
            }

            return pacienteDto;
        }

        public IEnumerable<PacienteDto> MapperListPacientesDto(IEnumerable<Paciente> pacientes)
        {
            var pacientesDto = new List<PacienteDto>();

            foreach (var paciente in pacientes)
            {
                var pacienteDto = new PacienteDto();
                var documentosDto = new List<DocumentoDto>();
                var enderecosDto = new List<EnderecoDto>();
                var telefonesDto = new List<TelefoneDto>();
                var emailsDto = new List<EmailDto>();

                //Paciente
                pacienteDto.Id = paciente.Id;
                pacienteDto.Nome = paciente.Nome;
                pacienteDto.Tipo = paciente.Tipo;
                pacienteDto.Status = paciente.Status;
                pacienteDto.IdProntuario = paciente.IdProntuario;

                if (paciente.Documentos != null)
                {
                    //Documentos do Paciente
                    foreach (var documento in paciente.Documentos)
                    {
                        var documentoDto = new DocumentoDto();

                        documentoDto.Id = documento.Id;
                        documentoDto.Tipo = documento.Tipo;
                        documentoDto.Numero = documento.Numero;

                        documentosDto.Add(documentoDto);
                    }
                    pacienteDto.Enderecos = enderecosDto;
                }

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
                    //Telefones do Paciente
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

                if (paciente.Emails != null)
                {
                    //Emails do Paciente
                    foreach (var telefone in paciente.Emails)
                    {
                        var emailDto = new EmailDto();

                        emailDto.Id = telefone.Id;
                        emailDto.Tipo = telefone.Tipo;
                        emailDto.Endereco = telefone.Endereco;
                        emailDto.Status = telefone.Status;

                        emailsDto.Add(emailDto);
                    }

                    pacienteDto.Emails = emailsDto;
                }

                pacientesDto.Add(pacienteDto);
            }

            return pacientesDto;
        }
    }
}
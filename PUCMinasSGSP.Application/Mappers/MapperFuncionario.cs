using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperFuncionario : IMapperFuncionario
    {
        public Funcionario MapperDtoToEntity(FuncionarioDto funcionarioDto)
        {
            var funcionario = new Funcionario();
            var documentos = new List<Documento>();
            var enderecos = new List<Endereco>();
            var telefones = new List<Telefone>();
            var emails = new List<Email>();

            funcionario.Id = funcionarioDto.Id;
            funcionario.Nome = funcionarioDto.Nome;
            funcionario.Tipo = funcionarioDto.Tipo;
            funcionario.Admissao = funcionarioDto.Admissao;
            funcionario.Status = funcionarioDto.Status;
            funcionario.IdCargo = funcionarioDto.IdCargo;

            if (funcionarioDto.Documentos != null)
            {
                foreach (var item in funcionarioDto.Documentos)
                {
                    var documento = new Documento()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        Numero = item.Numero
                    };

                    documentos.Add(documento);
                }

                funcionario.Documentos = documentos;
            }

            if (funcionarioDto.Enderecos != null)
            {
                foreach (var item in funcionarioDto.Enderecos)
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

                funcionario.Enderecos = enderecos;
            }

            if (funcionarioDto.Telefones != null)
            {
                foreach (var item in funcionarioDto.Telefones)
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

                funcionario.Telefones = telefones;
            }

            if (funcionarioDto.Emails != null)
            {
                foreach (var item in funcionarioDto.Emails)
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

                funcionario.Emails = emails;
            }

            return funcionario;
        }

        public FuncionarioDto MapperEntityToDto(Funcionario funcionario)
        {
            var funcionarioDto = new FuncionarioDto();
            var documentosDto = new List<DocumentoDto>();
            var enderecosDto = new List<EnderecoDto>();
            var telefonesDto = new List<TelefoneDto>();
            var emailsDto = new List<EmailDto>();

            funcionarioDto.Id = funcionario.Id;
            funcionarioDto.Nome = funcionario.Nome;
            funcionarioDto.Tipo = funcionario.Tipo;
            funcionarioDto.Admissao = funcionario.Admissao;
            funcionarioDto.Status = funcionario.Status;
            funcionario.IdCargo = funcionarioDto.IdCargo;

            if (funcionario.Documentos != null)
            {
                foreach (var item in funcionario.Documentos)
                {
                    var documentoDto = new DocumentoDto()
                    {
                        Id = item.Id,
                        Tipo = item.Tipo,
                        Numero = item.Numero
                    };

                    documentosDto.Add(documentoDto);
                }

                funcionarioDto.Documentos = documentosDto;
            }

            if (funcionario.Enderecos != null)
            {
                foreach (var item in funcionario.Enderecos)
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

                funcionarioDto.Enderecos = enderecosDto;
            }

            if (funcionario.Telefones != null)
            {
                foreach (var item in funcionario.Telefones)
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

                funcionarioDto.Enderecos = enderecosDto;
            }

            if (funcionario.Emails != null)
            {
                foreach (var item in funcionario.Emails)
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

                funcionarioDto.Emails = emailsDto;
            }

            return funcionarioDto;
        }

        public IEnumerable<FuncionarioDto> MapperListFuncionariosDto(IEnumerable<Funcionario> funcionarios)
        {
            var funcionariosDto = new List<FuncionarioDto>();

            foreach (var funcionario in funcionarios)
            {
                var funcionarioDto = new FuncionarioDto();
                var documentosDto = new List<DocumentoDto>();
                var enderecosDto = new List<EnderecoDto>();
                var telefonesDto = new List<TelefoneDto>();
                var emailsDto = new List<EmailDto>();

                //Paciente
                funcionarioDto.Id = funcionario.Id;
                funcionarioDto.Nome = funcionario.Nome;
                funcionarioDto.Tipo = funcionario.Tipo;
                funcionarioDto.Admissao = funcionario.Admissao;
                funcionarioDto.Status = funcionario.Status;
                funcionarioDto.IdCargo = funcionario.IdCargo;

                if (funcionario.Documentos != null)
                {
                    //Documentos do Paciente
                    foreach (var documento in funcionario.Documentos)
                    {
                        var documentoDto = new DocumentoDto();

                        documentoDto.Id = documento.Id;
                        documentoDto.Tipo = documento.Tipo;
                        documentoDto.Numero = documento.Numero;

                        documentosDto.Add(documentoDto);
                    }
                    funcionarioDto.Enderecos = enderecosDto;
                }

                if (funcionario.Enderecos != null)
                {
                    //Endereços do Paciente
                    foreach (var endereco in funcionario.Enderecos)
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
                    funcionarioDto.Enderecos = enderecosDto;
                }

                if (funcionario.Telefones != null)
                {
                    //Telefones do Paciente
                    foreach (var telefone in funcionario.Telefones)
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

                    funcionarioDto.Telefones = telefonesDto;
                }

                if (funcionario.Emails != null)
                {
                    //Emails do Paciente
                    foreach (var telefone in funcionario.Emails)
                    {
                        var emailDto = new EmailDto();

                        emailDto.Id = telefone.Id;
                        emailDto.Tipo = telefone.Tipo;
                        emailDto.Endereco = telefone.Endereco;
                        emailDto.Status = telefone.Status;

                        emailsDto.Add(emailDto);
                    }

                    funcionarioDto.Emails = emailsDto;
                }

                funcionariosDto.Add(funcionarioDto);
            }

            return funcionariosDto;
        }
    }
}
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperDetalhesProntuario : IMapperDetalhesProntuario
    {
      
        public DetalhesProntuario MapperDtoToEntity(DetalhesProntuarioDto detalhesProntuarioDto)
        {
            var detalhesProntuario = new DetalhesProntuario()
            {
                Id = detalhesProntuarioDto.Id,
                IdProntuario = detalhesProntuarioDto.IdProntuario,
                IdInternacao = detalhesProntuarioDto.IdInternacao,
                IdMedico = detalhesProntuarioDto.IdMedico,
                Solicitacao = detalhesProntuarioDto.Solicitacao,
                Execucao = detalhesProntuarioDto.Execucao,
                IdProcedimento = detalhesProntuarioDto.IdProcedimento,
                IdDiagnostico = detalhesProntuarioDto.IdDiagnostico,
                Observacoes = detalhesProntuarioDto.Observacoes

            };

            return detalhesProntuario;
        }

        public DetalhesProntuarioDto MapperEntityToDto(DetalhesProntuario detalhesProntuario)
        {
            var detalhesProntuarioDto = new DetalhesProntuarioDto()
            {
                Id = detalhesProntuario.Id,
                IdProntuario = detalhesProntuario.IdProntuario,
                IdInternacao = detalhesProntuario.IdInternacao,
                IdMedico = detalhesProntuario.IdMedico,
                Solicitacao = detalhesProntuario.Solicitacao,
                Execucao = detalhesProntuario.Execucao,
                IdProcedimento = detalhesProntuario.IdProcedimento,
                IdDiagnostico = detalhesProntuario.IdDiagnostico,
                Observacoes = detalhesProntuario.Observacoes
            };

            return detalhesProntuarioDto;
        }

        public IEnumerable<DetalhesProntuarioDto> MapperListDetalhesProntuariosDto(IEnumerable<DetalhesProntuario> detalhesProntuarios)
        {
            var detalhesProntuariosDto = detalhesProntuarios.Select(item => new DetalhesProntuarioDto
            {
                Id = item.Id,
                IdProntuario = item.IdProntuario,
                IdInternacao = item.IdInternacao,
                IdMedico = item.IdMedico,
                Solicitacao = item.Solicitacao,
                Execucao = item.Execucao,
                IdProcedimento = item.IdProcedimento,
                IdDiagnostico = item.IdDiagnostico,
                Observacoes = item.Observacoes
            });
            return detalhesProntuariosDto;
        }
    }
}
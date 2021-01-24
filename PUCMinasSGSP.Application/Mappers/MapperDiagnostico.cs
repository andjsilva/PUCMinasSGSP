using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperDiagnostico : IMapperDiagnostico

    {
        public Diagnostico MapperDtoToEntity(DiagnosticoDto diagnosticoDto)
        {
            var diagnostico = new Diagnostico()
            {
                Id = diagnosticoDto.Id,
                Tipo = diagnosticoDto.Tipo,
                IdProntuario = diagnosticoDto.IdProntuario,
                Entrada = diagnosticoDto.Entrada,
                Saida = diagnosticoDto.Saida,
                IdMedico = diagnosticoDto.IdMedico,
                IdUnidadeAtendimento = diagnosticoDto.IdUnidadeAtendimento
            };

            return diagnostico;
        }

        public DiagnosticoDto MapperEntityToDto(Diagnostico diagnostico)
        {
            var diagnosticoDto = new DiagnosticoDto()
            {
                Id = diagnostico.Id,
                Tipo = diagnostico.Tipo,
                IdProntuario = diagnostico.IdProntuario,
                Entrada = diagnostico.Entrada,
                Saida = diagnostico.Saida,
                IdMedico = diagnostico.IdMedico,
                IdUnidadeAtendimento = diagnostico.IdUnidadeAtendimento
            };

            return diagnosticoDto;
        }

        public IEnumerable<DiagnosticoDto> MapperListDiagnosticosDto(IEnumerable<Diagnostico> diagnosticos)
        {
            var diagnosticosDto = diagnosticos.Select(item => new DiagnosticoDto
            {
                Id = item.Id,
                Tipo = item.Tipo,
                IdProntuario = item.IdProntuario,
                Entrada = item.Entrada,
                Saida = item.Saida,
                IdMedico = item.IdMedico,
                IdUnidadeAtendimento = item.IdUnidadeAtendimento
            });
            return diagnosticosDto;
        }
    }
}
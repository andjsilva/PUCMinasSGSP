using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperProntuario : IMapperProntuario
    {
        
        public Prontuario MapperDtoToEntity(ProntuarioDto prontuarioDto)
        {
            var prontuario = new Prontuario()
            {
                Id = prontuarioDto.Id,
                Peso = prontuarioDto.Peso,
                Altura = prontuarioDto.Altura,
                TipoSanguinio = prontuarioDto.TipoSanguinio,
                RhSanguinio = prontuarioDto.RhSanguinio,
                AlergiasMedicacao = prontuarioDto.AlergiasMedicacao,
                Doencas = prontuarioDto.Doencas,
                Observacoes = prontuarioDto.Observacoes

            };

            return prontuario;
        }

        public ProntuarioDto MapperEntityToDto(Prontuario prontuario)
        {
            var prontuarioDto = new ProntuarioDto()
            {
                Id = prontuario.Id,
                Peso = prontuario.Peso,
                Altura = prontuario.Altura,
                TipoSanguinio = prontuario.TipoSanguinio,
                RhSanguinio = prontuario.RhSanguinio,
                AlergiasMedicacao = prontuario.AlergiasMedicacao,
                Doencas = prontuario.Doencas,
                Observacoes = prontuario.Observacoes
            };

            return prontuarioDto;
        }

        public IEnumerable<ProntuarioDto> MapperListProntuariosDto(IEnumerable<Prontuario> prontuarios)
        {
            var prontuariosDto = prontuarios.Select(item => new ProntuarioDto
            {
                Id = item.Id,
                Peso = item.Peso,
                Altura = item.Altura,
                TipoSanguinio = item.TipoSanguinio,
                RhSanguinio = item.RhSanguinio,
                AlergiasMedicacao = item.AlergiasMedicacao,
                Doencas = item.Doencas,
                Observacoes = item.Observacoes
            });
            return prontuariosDto;
        }
    }
}
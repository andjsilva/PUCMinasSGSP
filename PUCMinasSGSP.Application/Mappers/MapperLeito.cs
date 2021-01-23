using System;
using System.Collections.Generic;
using System.Linq;
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperLeito : IMapperLeito
    {
        public Leito MapperDtoToEntity(LeitoDto leitoDto)
        {
            var leito = new Leito()
            {
                Id = leitoDto.Id,
                Tipo = leitoDto.Tipo,
                IdUnidadeAtendimento = leitoDto.IdUnidadeAtendimento,
                Descricao = leitoDto.Descricao,
                Localizacao = leitoDto.Localizacao,
                Status = leitoDto.Status,
                Disponivel = leitoDto.Disponivel,
                Observacoes = leitoDto.Observacoes

            };

            return leito;
        }

        public LeitoDto MapperEntityToDto(Leito leito)
        {
            var leitoDto = new LeitoDto()
            {
                Id = leito.Id,
                Tipo = leito.Tipo,
                IdUnidadeAtendimento = leito.IdUnidadeAtendimento,
                Descricao = leito.Descricao,
                Localizacao = leito.Localizacao,
                Status = leito.Status,
                Disponivel = leito.Disponivel,
                Observacoes = leito.Observacoes

            };

            return leitoDto;
        }

        public IEnumerable<LeitoDto> MapperListLeitosDto(IEnumerable<Leito> leitos)
        {
            var leitosDto = leitos.Select(item => new LeitoDto
            {
                Id = item.Id,
                Tipo = item.Tipo,
                IdUnidadeAtendimento = item.IdUnidadeAtendimento,
                Descricao = item.Descricao,
                Localizacao = item.Localizacao,
                Status = item.Status,
                Disponivel = item.Disponivel,
                Observacoes = item.Observacoes
            });

            return leitosDto;
        }
    }
}

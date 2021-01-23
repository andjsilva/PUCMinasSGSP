using System;
using System.Collections.Generic;
using System.Linq;
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperCampanha : IMapperCampanha
    {
       
        public Campanha MapperDtoToEntity(CampanhaDto campanhaDto)
        {
            var campanha = new Campanha()
            {
                Id = campanhaDto.Id,
                Descricao = campanhaDto.Descricao,
                Inicio = campanhaDto.Inicio,
                Fim = campanhaDto.Fim,
                IdUnidadeAtendimento = campanhaDto.IdUnidadeAtendimento

            };

            return campanha;
        }

        public CampanhaDto MapperEntityToDto(Campanha campanha)
        {
            var campanhaDto = new CampanhaDto()
            {
                Id = campanha.Id,
                Descricao = campanha.Descricao,
                Inicio = campanha.Inicio,
                Fim = campanha.Fim,
                IdUnidadeAtendimento = campanha.IdUnidadeAtendimento

            };

            return campanhaDto;
        }

        public IEnumerable<CampanhaDto> MapperListCampanhasDto(IEnumerable<Campanha> campanhas)
        {
            var campanhasDto = campanhas.Select(item => new CampanhaDto
            {
                Id = item.Id,
                Descricao = item.Descricao,
                Inicio = item.Inicio,
                Fim = item.Fim,
                IdUnidadeAtendimento = item.IdUnidadeAtendimento
            });

            return campanhasDto;
        }
    }
}

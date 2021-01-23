using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperCampanha
    {
        Campanha MapperDtoToEntity(CampanhaDto campanhaDto);

        IEnumerable<CampanhaDto> MapperListCampanhasDto(IEnumerable<Campanha> campanhas);

        CampanhaDto MapperEntityToDto(Campanha campanha);
    }
}
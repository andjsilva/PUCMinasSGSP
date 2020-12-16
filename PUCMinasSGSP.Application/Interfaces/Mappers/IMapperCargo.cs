using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperCargo
    { 
        Cargo MapperDtoToEntity(CargoDto cargoDto);

        IEnumerable<CargoDto> MapperListCargosDto(IEnumerable<Cargo> estoques);

        CargoDto MapperEntityToDto(Cargo cargo);

    }
}

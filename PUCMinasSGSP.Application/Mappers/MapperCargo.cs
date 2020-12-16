using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperCargo : IMapperCargo
    {
        public Cargo MapperDtoToEntity(CargoDto cargoDto)
        {
            var cargo = new Cargo()
            {
                Id = cargoDto.Id,
                Descricao = cargoDto.Descricao
            };

            return cargo;
        }

        public CargoDto MapperEntityToDto(Cargo cargo)
        {
            var cargoDto = new CargoDto()
            {
                Id = cargo.Id,
                Descricao = cargo.Descricao
            };

            return cargoDto;
        }

        public IEnumerable<CargoDto> MapperListCargosDto(IEnumerable<Cargo> cargos)
        {
            var cargosDto = cargos.Select(item => new CargoDto
            {
                Id = item.Id,
                Descricao = item.Descricao
            });
            return cargosDto;
        }
    }
}
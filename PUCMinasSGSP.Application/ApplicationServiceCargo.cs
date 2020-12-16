using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceCargo : IApplicationServiceCargo
    {
        private readonly IServiceCargo serviceCargo;
        private readonly IMapperCargo mapperCargo;

        public ApplicationServiceCargo(IServiceCargo serviceCargo,
                                          IMapperCargo mapperCargo)
        {
            this.serviceCargo = serviceCargo;
            this.mapperCargo = mapperCargo;
        }

        public async Task<CargoDto> AddAsync(CargoDto cargoDto)
        {
            var cargo = this.mapperCargo.MapperDtoToEntity(cargoDto);
            var result = await this.serviceCargo.AddAsync(cargo);
            return this.mapperCargo.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<CargoDto>> GetAllAsync()
        {
            var cargos = await this.serviceCargo.GetAllAsync();
            return this.mapperCargo.MapperListCargosDto(cargos);
        }

        public async Task<CargoDto> GetByIdAsync(Guid id)
        {
            var cargo = await this.serviceCargo.GetByIdAsync(id);
            return this.mapperCargo.MapperEntityToDto(cargo);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var cargo = await this.serviceCargo.GetByIdAsync(id);

            if (cargo == null)
                return false;

            await this.serviceCargo.RemoveAsync(cargo);
            return true;
        }

        public async Task<CargoDto> UpdateAsync(Guid id, CargoDto cargoDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                cargoDto.Id = result.Id;

                var cargo = this.mapperCargo.MapperDtoToEntity(cargoDto);

                await this.serviceCargo.UpdateAsync(cargo);

                return await this.GetByIdAsync(cargo.Id);
            }
            else
            {
                return new CargoDto();
            }
        }
    }
}
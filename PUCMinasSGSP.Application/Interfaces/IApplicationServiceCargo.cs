using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceCargo
    {
        Task<CargoDto> AddAsync(CargoDto cargoDto);

        Task<CargoDto> UpdateAsync(Guid id, CargoDto cargoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<CargoDto>> GetAllAsync();

        Task<CargoDto> GetByIdAsync(Guid id);
    }
}
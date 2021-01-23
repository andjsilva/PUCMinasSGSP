using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceCampanha
    {
        Task<CampanhaDto> AddAsync(CampanhaDto campanhaDto);

        Task<CampanhaDto> UpdateAsync(Guid id, CampanhaDto campanhaDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<CampanhaDto>> GetAllAsync();

        Task<CampanhaDto> GetByIdAsync(Guid id);
    }
}
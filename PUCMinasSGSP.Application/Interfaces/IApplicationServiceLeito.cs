using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceLeito
    {
        Task<LeitoDto> AddAsync(LeitoDto leitoDto);

        Task<LeitoDto> UpdateAsync(Guid id, LeitoDto leitoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<LeitoDto>> GetAllAsync();

        Task<LeitoDto> GetByIdAsync(Guid id);
    }
}
using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceProntuario
    {
        Task<ProntuarioDto> AddAsync(ProntuarioDto prontuarioDto);

        Task<ProntuarioDto> UpdateAsync(Guid id, ProntuarioDto prontuarioDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<ProntuarioDto>> GetAllAsync();

        Task<ProntuarioDto> GetByIdAsync(Guid id);
    }
}
using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceDiagnostico
    {
        Task<DiagnosticoDto> AddAsync(DiagnosticoDto diagnosticoDto);

        Task<DiagnosticoDto> UpdateAsync(Guid id, DiagnosticoDto diagnosticoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<DiagnosticoDto>> GetAllAsync();

        Task<DiagnosticoDto> GetByIdAsync(Guid id);
    }
}
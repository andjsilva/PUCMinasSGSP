using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServicePaciente
    {
        Task<PacienteDto> AddAsync(PacienteDto pacienteDto);

        Task<PacienteDto> UpdateAsync(Guid id, PacienteDto pacienteDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<PacienteDto>> GetAllAsync();

        Task<PacienteDto> GetByIdAsync(Guid id);
    }
}
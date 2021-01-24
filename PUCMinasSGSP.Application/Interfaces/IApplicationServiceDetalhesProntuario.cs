using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceDetalhesProntuario
    {
        Task<DetalhesProntuarioDto> AddAsync(DetalhesProntuarioDto detalhesProntuarioDto);

        Task<DetalhesProntuarioDto> UpdateAsync(Guid id, DetalhesProntuarioDto detalhesProntuarioDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<DetalhesProntuarioDto>> GetAllAsync();

        Task<DetalhesProntuarioDto> GetByIdAsync(Guid id);
    }
}
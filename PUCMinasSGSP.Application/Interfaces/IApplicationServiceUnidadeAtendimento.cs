using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceUnidadeAtendimento
    {
        Task<UnidadeAtendimentoDto> AddAsync(UnidadeAtendimentoDto unidadeAtendimentoDto);

        Task<UnidadeAtendimentoDto> UpdateAsync(Guid id, UnidadeAtendimentoDto unidadeAtendimentoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<UnidadeAtendimentoDto>> GetAllAsync();

        Task<UnidadeAtendimentoDto> GetByIdAsync(Guid id);
    }
}
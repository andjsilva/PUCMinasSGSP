using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceTelefone
    {
        Task<TelefoneDto> AddAsync(EntidadeEnum entidade, Guid idEntidade, TelefoneDto telefoneDto);

        Task<TelefoneDto> UpdateAsync(Guid id, TelefoneDto telefoneDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<TelefoneDto>> GetAllAsync();

        Task<TelefoneDto> GetByIdAsync(Guid id);
    }
}
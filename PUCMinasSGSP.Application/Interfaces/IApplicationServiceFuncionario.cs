using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceFuncionario
    {
        Task<FuncionarioDto> AddAsync(FuncionarioDto funcionarioDto);

        Task<FuncionarioDto> UpdateAsync(Guid id, FuncionarioDto funcionarioDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<FuncionarioDto>> GetAllAsync();

        Task<FuncionarioDto> GetByIdAsync(Guid id);
    }
}
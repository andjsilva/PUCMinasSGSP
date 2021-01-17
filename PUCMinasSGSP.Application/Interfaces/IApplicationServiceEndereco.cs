using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        Task<EnderecoDto> AddAsync(EntidadeEnum entidade, Guid idEntidade, EnderecoDto enderecoDto);

        Task<EnderecoDto> UpdateAsync(Guid id, EnderecoDto enderecoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<EnderecoDto>> GetAllAsync();

        Task<EnderecoDto> GetByIdAsync(Guid id);
    }
}
using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        Task<EnderecoDto> AddAsync(EnderecoDto EnderecoDto);

        Task<EnderecoDto> UpdateAsync(Guid id, EnderecoDto EnderecoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<EnderecoDto>> GetAllAsync();

        Task<EnderecoDto> GetByIdAsync(Guid id);
    }
}

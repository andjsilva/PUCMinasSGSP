using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        Task<ProdutoDto> AddAsync(ProdutoDto produtoDto);

        Task<ProdutoDto> UpdateAsync(Guid id, ProdutoDto produtoDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<ProdutoDto>> GetAllAsync();

        Task<ProdutoDto> GetByIdAsync(Guid id);
    }
}

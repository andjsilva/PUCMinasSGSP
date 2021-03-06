﻿using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceEstoque
    {
        Task<EstoqueDto> AddAsync(EstoqueDto estoqueDto);

        Task<EstoqueDto> UpdateAsync(Guid id, EstoqueDto estoqueDto);

        Task<bool> RemoveAsync(Guid id);

        Task<IEnumerable<EstoqueDto>> GetAllAsync();

        Task<EstoqueDto> GetByIdAsync(Guid id);
    }
}
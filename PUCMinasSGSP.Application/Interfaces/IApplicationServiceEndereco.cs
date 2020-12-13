using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        EnderecoDto Add(EnderecoDto EnderecoDto);

        EnderecoDto Update(Guid id, EnderecoDto EnderecoDto);

        bool Remove(Guid id);

        IEnumerable<EnderecoDto> GetAll();

        EnderecoDto GetById(Guid id);
    }
}

using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        void Add(EnderecoDto clienteDto);

        void Update(EnderecoDto clienteDto);

        void Remove(EnderecoDto clienteDto);

        IEnumerable<EnderecoDto> GetAll();

        EnderecoDto GetById(Guid id);
    }
}

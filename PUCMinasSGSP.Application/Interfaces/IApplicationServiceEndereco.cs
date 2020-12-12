using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        void Add(EnderecoDto enderecoDto);

        void Update(EnderecoDto enderecoDto);

        void Remove(EnderecoDto enderecoDto);

        IEnumerable<EnderecoDto> GetAll();

        EnderecoDto GetById(Guid id);
    }
}

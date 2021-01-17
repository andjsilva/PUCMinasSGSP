using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Interfaces.Mappers
{
    public interface IMapperFuncionario
    {
        Funcionario MapperDtoToEntity(FuncionarioDto funcionarioDto);

        IEnumerable<FuncionarioDto> MapperListFuncionariosDto(IEnumerable<Funcionario> funcionarios);

        FuncionarioDto MapperEntityToDto(Funcionario funcionario);
    }
}
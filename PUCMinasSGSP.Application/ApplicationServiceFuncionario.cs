using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceFuncionario : IApplicationServiceFuncionario
    {
        private readonly IServiceFuncionario serviceFuncionario;
        private readonly IMapperFuncionario mapperFuncionario;

        public ApplicationServiceFuncionario(IServiceFuncionario serviceFuncionario,
                                          IMapperFuncionario mapperFuncionario)
        {
            this.serviceFuncionario = serviceFuncionario;
            this.mapperFuncionario = mapperFuncionario;
        }

        public async Task<FuncionarioDto> AddAsync(FuncionarioDto funcionarioDto)
        {
            var paciente = this.mapperFuncionario.MapperDtoToEntity(funcionarioDto);
            var result = await this.serviceFuncionario.AddAsync(paciente);
            return this.mapperFuncionario.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<FuncionarioDto>> GetAllAsync()
        {
            var pacientes = await this.serviceFuncionario.GetAllAsync();

            return this.mapperFuncionario.MapperListFuncionariosDto(pacientes);

        }

        public async Task<FuncionarioDto> GetByIdAsync(Guid id)
        {
            var funcionario = await this.serviceFuncionario.GetByIdAsync(id);
            return this.mapperFuncionario.MapperEntityToDto(funcionario);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var funcionario = await this.serviceFuncionario.GetByIdAsync(id);

            if (funcionario == null)
                return false;

            await this.serviceFuncionario.RemoveAsync(funcionario);
            return true;
         
        }

        public async Task<FuncionarioDto> UpdateAsync(Guid id, FuncionarioDto funcionarioDto)
        {
            var result = await this.serviceFuncionario.GetByIdAsync(id);

            if (result != null)
            {
                funcionarioDto.Id = result.Id;

                var funcionario = this.mapperFuncionario.MapperDtoToEntity(funcionarioDto);

                await this.serviceFuncionario.UpdateAsync(funcionario);

                return await this.GetByIdAsync(funcionario.Id);
            }
            else
            {
                return new FuncionarioDto();
            }         

        }
    }
}

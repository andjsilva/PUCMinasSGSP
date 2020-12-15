using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Common.Enums;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceTelefone : IApplicationServiceTelefone
    {
        private readonly IServiceTelefone serviceTelefone;
        private readonly IMapperTelefone mapperTelefone;

        public ApplicationServiceTelefone(IServiceTelefone serviceTelefone,
                                          IMapperTelefone mapperTelefone)
        {
            this.serviceTelefone = serviceTelefone;
            this.mapperTelefone = mapperTelefone;
        }

        public async Task<TelefoneDto> AddAsync(EntidadeEnum entidade, Guid idEntidade, TelefoneDto telefoneDto)
        {
            var telefone = this.mapperTelefone.MapperDtoToEntity(telefoneDto);

            if (EntidadeEnum.Funcionario == entidade || EntidadeEnum.Paciente == entidade)
            {
                telefone.IdPessoa = idEntidade;
            }
            else
            {
                telefone.IdUnidadeAtendimento = idEntidade;
            }

            var result = await this.serviceTelefone.AddAsync(telefone);
            return this.mapperTelefone.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<TelefoneDto>> GetAllAsync()
        {
            var telefones = await this.serviceTelefone.GetAllAsync();

            return this.mapperTelefone.MapperListTelefonesDto(telefones);
        }

        public async Task<TelefoneDto> GetByIdAsync(Guid id)
        {
            var telefone = await this.serviceTelefone.GetByIdAsync(id);
            return this.mapperTelefone.MapperEntityToDto(telefone);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var telefone = await this.serviceTelefone.GetByIdAsync(id);

            if (telefone == null)
                return false;

            await this.serviceTelefone.RemoveAsync(telefone);
            return true;
        }

        public async Task<TelefoneDto> UpdateAsync(Guid id, TelefoneDto telefoneDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                telefoneDto.Id = result.Id;

                var telefone = this.mapperTelefone.MapperDtoToEntity(telefoneDto);

                await this.serviceTelefone.UpdateAsync(telefone);

                return await this.GetByIdAsync(telefone.Id);
            }
            else
            {
                return new TelefoneDto();
            }
        }
    }
}
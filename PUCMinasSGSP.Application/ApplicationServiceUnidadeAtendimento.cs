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
    public class ApplicationServiceUnidadeAtendimento : IApplicationServiceUnidadeAtendimento
    {
        private readonly IServiceUnidadeAtendimento serviceUnidadeAtendimento;
        private readonly IMapperUnidadeAtendimento mapperUnidadeAtendimento;

        public ApplicationServiceUnidadeAtendimento(IServiceUnidadeAtendimento serviceUnidadeAtendimento,
                                                    IMapperUnidadeAtendimento mapperUnidadeAtendimento)
        {
            this.serviceUnidadeAtendimento = serviceUnidadeAtendimento;
            this.mapperUnidadeAtendimento = mapperUnidadeAtendimento;
        }

        public async Task<UnidadeAtendimentoDto> AddAsync(UnidadeAtendimentoDto unidadeAtendimentoDto)
        {
            var unidadeAtendimento = this.mapperUnidadeAtendimento.MapperDtoToEntity(unidadeAtendimentoDto);
            var result = await this.serviceUnidadeAtendimento.AddAsync(unidadeAtendimento);
            return this.mapperUnidadeAtendimento.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<UnidadeAtendimentoDto>> GetAllAsync()
        {
            var unidadesAtendimento = await this.serviceUnidadeAtendimento.GetAllAsync();

            return this.mapperUnidadeAtendimento.MapperListUnidadesAtendimentoDto(unidadesAtendimento);

        }

        public async Task<UnidadeAtendimentoDto> GetByIdAsync(Guid id)
        {
            var unidadeAtendimento = await this.serviceUnidadeAtendimento.GetByIdAsync(id);
            return this.mapperUnidadeAtendimento.MapperEntityToDto(unidadeAtendimento);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var unidadeAtendimento = await this.serviceUnidadeAtendimento.GetByIdAsync(id);

            if (unidadeAtendimento == null)
                return false;

            await this.serviceUnidadeAtendimento.RemoveAsync(unidadeAtendimento);
            return true;
         
        }

        public async Task<UnidadeAtendimentoDto> UpdateAsync(Guid id, UnidadeAtendimentoDto unidadeAtendimentoDto)
        {
            var result = await this.serviceUnidadeAtendimento.GetByIdAsync(id);

            if (result != null)
            {
                unidadeAtendimentoDto.Id = result.Id;

                var unidadeAtendimento = this.mapperUnidadeAtendimento.MapperDtoToEntity(unidadeAtendimentoDto);

                await this.serviceUnidadeAtendimento.UpdateAsync(unidadeAtendimento);

                return await this.GetByIdAsync(unidadeAtendimento.Id);
            }
            else
            {
                return new UnidadeAtendimentoDto();
            }         

        }
    }
}

using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceCampanha : IApplicationServiceCampanha
    {
        private readonly IServiceCampanha serviceCampanha;
        private readonly IMapperCampanha mapperCampanha;

        public ApplicationServiceCampanha(IServiceCampanha serviceCampanha,
                                          IMapperCampanha mapperCampanha)
        {
            this.serviceCampanha = serviceCampanha;
            this.mapperCampanha = mapperCampanha;
        }

        public async Task<CampanhaDto> AddAsync(CampanhaDto campanhaDto)
        {
            var campanha = this.mapperCampanha.MapperDtoToEntity(campanhaDto);
            var result = await this.serviceCampanha.AddAsync(campanha);
            return this.mapperCampanha.MapperEntityToDto(result);
        }

        public async Task<IEnumerable<CampanhaDto>> GetAllAsync()
        {
            var campanhas = await this.serviceCampanha.GetAllAsync();
            return this.mapperCampanha.MapperListCampanhasDto(campanhas);
        }

        public async Task<CampanhaDto> GetByIdAsync(Guid id)
        {
            var campanha = await this.serviceCampanha.GetByIdAsync(id);
            return this.mapperCampanha.MapperEntityToDto(campanha);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var campanha = await this.serviceCampanha.GetByIdAsync(id);

            if (campanha == null)
                return false;

            await this.serviceCampanha.RemoveAsync(campanha);
            return true;
        }

        public async Task<CampanhaDto> UpdateAsync(Guid id, CampanhaDto campanhaDto)
        {
            var result = await this.GetByIdAsync(id);

            if (result != null)
            {
                campanhaDto.Id = result.Id;

                var campanha = this.mapperCampanha.MapperDtoToEntity(campanhaDto);

                await this.serviceCampanha.UpdateAsync(campanha);

                return await this.GetByIdAsync(campanha.Id);
            }
            else
            {
                return new CampanhaDto();
            }
        }
    }
}
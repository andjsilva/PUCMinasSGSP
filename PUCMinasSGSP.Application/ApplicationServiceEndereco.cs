using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application
{
    public class ApplicationServiceEndereco : IApplicationServiceEndereco
    {
        private readonly IServiceEndereco serviceEndereco;
        private readonly IMapperEndereco mapperEndereco;

        public ApplicationServiceEndereco(IServiceEndereco serviceEndereco,
                                          IMapperEndereco mapperEndereco)
        {
            this.serviceEndereco = serviceEndereco;
            this.mapperEndereco = mapperEndereco;
        }

        public EnderecoDto Add(EnderecoDto enderecoDto)
        {
            var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);
            var result = this.serviceEndereco.Add(endereco);
            return this.mapperEndereco.MapperEntityToDto(result);
        }

        public IEnumerable<EnderecoDto> GetAll()
        {
            var enderecos = this.serviceEndereco.GetAll();

            return this.mapperEndereco.MapperListEnderecosDto(enderecos);

        }

        public EnderecoDto GetById(Guid id)
        {
            var endereco = this.serviceEndereco.GetById(id);
            return this.mapperEndereco.MapperEntityToDto(endereco);
        }

        public bool Remove(Guid id)
        {
            var endereco = this.serviceEndereco.GetById(id);

            if (endereco == null)
                return false;

            this.serviceEndereco.Remove(endereco);
            return true;

        }

        public EnderecoDto Update(Guid id, EnderecoDto enderecoDto)
        {
            var result = this.GetById(id);

            if (result != null)
            {
                enderecoDto.Id = result.Id;

                var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);

                this.serviceEndereco.Update(endereco);

                return this.GetById(endereco.Id);
            }
            else
            {
                return new EnderecoDto();
            }         

        }
    }
}

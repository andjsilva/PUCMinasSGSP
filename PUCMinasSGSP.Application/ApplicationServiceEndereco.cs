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

        public void Add(EnderecoDto enderecoDto)
        {
            var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);
            this.serviceEndereco.Add(endereco);
        }

        public IEnumerable<EnderecoDto> GetAll()
        {
            var enderecos = this.serviceEndereco.GetAll();
            return this.mapperEndereco.MapperListEnderecoDto(enderecos);
        }

        public EnderecoDto GetById(Guid id)
        {
            var endereco = this.serviceEndereco.GetById(id);
            return this.mapperEndereco.MapperEntityToDto(endereco);
        }

        public void Remove(EnderecoDto enderecoDto)
        {
            var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);
            this.serviceEndereco.Remove(endereco);
        }

        public void Update(EnderecoDto enderecoDto)
        {
            var endereco = this.mapperEndereco.MapperDtoToEntity(enderecoDto);
            this.serviceEndereco.Update(endereco);
        }
    }
}

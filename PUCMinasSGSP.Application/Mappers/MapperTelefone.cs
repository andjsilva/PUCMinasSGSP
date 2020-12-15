using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Application.Mappers
{
    public class MapperTelefone : IMapperTelefone
    {
        public Telefone MapperDtoToEntity(TelefoneDto telefoneDto)
        {
            var telefone = new Telefone()
            {
                Id = telefoneDto.Id,
                Tipo = telefoneDto.Tipo,
                DDI = telefoneDto.DDI,
                DDD = telefoneDto.DDD,
                Numero = telefoneDto.Numero,
                Recado = telefoneDto.Recado,
                Complemento = telefoneDto.Complemento
            };

            return telefone;
        }

        public TelefoneDto MapperEntityToDto(Telefone telefone)
        {
            var telefoneDto = new TelefoneDto()
            {
                Id = telefone.Id,
                Tipo = telefone.Tipo,
                DDI = telefone.DDI,
                DDD = telefone.DDD,
                Numero = telefone.Numero,
                Recado = telefone.Recado,
                Complemento = telefone.Complemento
            };

            return telefoneDto;
        }

        public IEnumerable<TelefoneDto> MapperListTelefonesDto(IEnumerable<Telefone> telefones)
        {
            var telefoneDto = telefones.Select(c => new TelefoneDto
            {
                Id = c.Id,
                Tipo = c.Tipo,
                DDI = c.DDI,
                DDD = c.DDD,
                Numero = c.Numero,
                Recado = c.Recado,
                Complemento = c.Complemento
            });
            return telefoneDto;
        }
    }
}
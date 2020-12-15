using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Dtos
{
    public class UnidadeAtendimentoDto
    {
        public Guid Id { get; set; }

        public TipoUnidadeAtendimentoEnum Tipo { get; set; }

        public string Nome { get; set; }

        public virtual EnderecoDto Endereco { get; set; }

        public virtual ICollection<TelefoneDto> Telefones { get; set; }
    }
}
using System;
using System.Collections.Generic;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class UnidadeAtendimento
    {
        public Guid Id { get; set; }

        public TipoUnidadeAtendimentoEnum Tipo { get; set; }

        public string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set;}

        public virtual ICollection<Estoque> Estoque { get; set; }

    }
}

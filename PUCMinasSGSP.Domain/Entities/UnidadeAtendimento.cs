using System;
using System.Collections.Generic;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class UnidadeAtendimento
    {
        public Guid Id { get; set; }

        public TipoUnidadeAtendimento Tipo { get; set; }

        public string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set;}

    }
}

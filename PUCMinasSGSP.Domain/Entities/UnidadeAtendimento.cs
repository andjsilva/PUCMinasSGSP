using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class UnidadeAtendimento
    {
        public Guid Id { get; set; }

        public TipoUnidadeAtendimentoEnum Tipo { get; set; }

        public string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }

        public virtual ICollection<Estoque> Estoque { get; set; }

        public virtual ICollection<Campanha> Campanhas { get; set; }

        public virtual ICollection<Leito> Leitos { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}
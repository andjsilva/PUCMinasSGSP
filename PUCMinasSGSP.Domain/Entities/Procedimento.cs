using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Procedimento
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public TipoProcedimentoEnum Tipo { get; set; }

        public virtual ICollection<DetalhesProntuario> DetalhesProntuario { get; set; }
    }
}
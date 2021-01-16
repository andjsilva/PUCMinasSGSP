using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Procedimento
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public TipoProcedimentoEnum Tipo { get; set; }
    }
}

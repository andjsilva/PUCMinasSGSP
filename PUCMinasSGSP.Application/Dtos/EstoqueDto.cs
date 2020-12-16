using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class EstoqueDto
    {
        public Guid Id { get; set; }

        public Guid IdProduto { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

        public double Quantidade { get; set; }
    }
}

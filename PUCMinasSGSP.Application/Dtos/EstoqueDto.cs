using System;

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
using System;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Estoque
    {
        public Guid Id { get; set; }

        public Guid IdProduto { get; set; }

        public virtual Produto Produto { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

        public virtual UnidadeAtendimento UnidadeAtendimento { get; set; }

        public double Quantidade { get; set; }
    }
}
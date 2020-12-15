using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }

        public TipoProdutoEnum Tipo { get; set; }

        public string Descricao { get; set; }

        public UnidadeMedidaEnum UnidadeMedida { get; set; }

        public double Quantidade { get; set; }

        public StatusEnum Status { get; set; }
    }
}

using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }

        public string IdFabricante { get; set; }

        public TipoProdutoEnum Tipo { get; set; }

        public string Descricao { get; set; }

        public string Fabricante { get; set; }

        public UnidadeMedidaEnum UnidadeMedida { get; set; }

        public StatusEnum Status { get; set; }

        public virtual ICollection<Estoque> Estoque { get; set; }
    }
}
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }

        public string IdFabricante { get; set; }

        public TipoProdutoEnum Tipo { get; set; }

        public string Descricao { get; set; }

        public string Fabricante { get; set; }

        public UnidadeMedidaEnum UnidadeMedida { get; set; }

        public StatusEnum Status { get; set; }
    }
}

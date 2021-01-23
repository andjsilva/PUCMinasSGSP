using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Application.Dtos
{
    public class LeitoDto
    {
        public Guid Id { get; set; }

        public TipoLeitoEnum Tipo { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

        public string Descricao { get; set; }

        public string Localizacao { get; set; }

        public StatusEnum Status { get; set; }

        public bool Disponivel { get; set; }

        public string Observacoes { get; set; }

    }
}
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Leito
    {
        public Guid Id { get; set; }

        public TipoLeitoEnum Tipo { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

        public virtual UnidadeAtendimento UnidadeAtendimento { get; set; }

        public string Descricao { get; set; }

        public string Localizacao { get; set; }

        public StatusEnum Status { get; set; }

        public bool Disponivel { get; set; }

        public string Observacoes { get; set; }

        public virtual ICollection<Internacao> Internacoes { get; set; }
    }
}

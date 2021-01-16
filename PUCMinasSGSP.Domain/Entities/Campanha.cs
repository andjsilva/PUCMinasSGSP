using System;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Campanha
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

        public virtual UnidadeAtendimento UnidadeAtendimento { get; set; }
    }
}
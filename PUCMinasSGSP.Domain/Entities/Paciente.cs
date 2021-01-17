using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Paciente : Pessoa
    {
        public StatusEnum Status { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }

        public Guid IdProntuario { get; set; }

        public virtual Prontuario Prontuario { get; set; }
    }
}
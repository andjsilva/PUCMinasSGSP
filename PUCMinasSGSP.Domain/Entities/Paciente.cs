using System;
using System.Collections.Generic;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Paciente : Pessoa
    {
     
        public StatusEnum Status { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }

        public virtual Prontuario Prontuario { get; set; }

    }
}

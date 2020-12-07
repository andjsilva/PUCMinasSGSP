using System;
using System.Collections.Generic;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Paciente : Pessoa
    {
     
        public Status Status { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }

    }
}

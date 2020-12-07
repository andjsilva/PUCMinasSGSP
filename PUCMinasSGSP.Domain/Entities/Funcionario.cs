using System;
using System.Collections.Generic;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Funcionario : Pessoa
    {
    
        public DateTime Admissao { get; set; }

        public Status Status { get; set; }

        public Guid IdCargo { get; set; }

        public virtual Cargo Cargo { get; set; }

        public virtual ICollection<EspecialidadeFuncionario> Especialidades { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }

     }
}

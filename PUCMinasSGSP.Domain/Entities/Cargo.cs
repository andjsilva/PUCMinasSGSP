using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Cargo
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}

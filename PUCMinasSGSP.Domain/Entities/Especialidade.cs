using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Especialidade
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<EspecialidadeFuncionario> Funcionarios { get; set; }
    }
}
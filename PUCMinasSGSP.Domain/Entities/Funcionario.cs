using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Funcionario : Pessoa
    {
        public DateTime Admissao { get; set; }

        public Guid IdPessoa { get; set; }

        public Status Status { get; set; }

     }
}

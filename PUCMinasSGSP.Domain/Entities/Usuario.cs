using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public abstract class Usuario : Pessoa
    {
        
        public string IdUsuario { get; set; }

        public string Senha { get; set; }

        public Status Status { get; set; }

        public string Email { get; set; }

        public Guid IdPessoa { get; set; }
        
    }
}

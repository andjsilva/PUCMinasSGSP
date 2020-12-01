using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Email
    {
        public Guid Id { get; set; }

        public TipoEmail Tipo { get; set; }

        public string Endereco { get; set; }

        public Status Status { get; set; }

        public Guid IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }

    }
}

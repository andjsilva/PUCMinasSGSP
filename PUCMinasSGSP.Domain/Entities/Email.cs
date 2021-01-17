using PUCMinasSGSP.Common.Enums;
using System;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Email
    {
        public Guid Id { get; set; }

        public TipoEmailEnum Tipo { get; set; }

        public string Endereco { get; set; }

        public StatusEnum Status { get; set; }

        public Guid IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
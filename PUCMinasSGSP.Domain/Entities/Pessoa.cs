using System;
using System.Collections.Generic;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Pessoa
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public TipoPessoa Tipo { get; set; }

        public virtual ICollection<Email> Emails { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}

using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public abstract class Pessoa
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public TipoPessoaEnum Tipo { get; set; }

        public virtual ICollection<Email> Emails { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
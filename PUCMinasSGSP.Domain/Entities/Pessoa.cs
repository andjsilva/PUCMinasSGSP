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

        public List<Email> Emails { get; set; }

        public List<Telefone> Telefones { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public List<Documento> Documentos { get; set; }
    }
}

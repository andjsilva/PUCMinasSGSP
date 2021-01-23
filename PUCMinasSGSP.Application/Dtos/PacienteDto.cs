using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Application.Dtos
{
    public class PacienteDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public TipoPessoaEnum Tipo { get; set; }

        public StatusEnum Status { get; set; }

        public Guid IdProntuario { get; set; }

        public virtual ICollection<DocumentoDto> Documentos { get; set; }

        public virtual ICollection<EnderecoDto> Enderecos { get; set; }

        public virtual ICollection<TelefoneDto> Telefones { get; set; }

        public virtual ICollection<EmailDto> Emails { get; set; }
    }
}
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class FuncionarioDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public TipoPessoaEnum Tipo { get; set; }

        public DateTime Admissao { get; set; }

        public StatusEnum Status { get; set; }

        public Guid IdCargo { get; set; }

        public virtual ICollection<DocumentoDto> Documentos { get; set; }

        public virtual ICollection<EnderecoDto> Enderecos { get; set; }

        public virtual ICollection<TelefoneDto> Telefones { get; set; }

        public virtual ICollection<EmailDto> Emails { get; set; }



    }
}

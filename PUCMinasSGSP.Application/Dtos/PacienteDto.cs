using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class PacienteDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<EnderecoDto> Enderecos { get; set; }


    }
}

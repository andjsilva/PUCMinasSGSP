using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class DocumentoDto
    {
        public Guid Id { get; set; }

        public TipoDocumentoEnum Tipo { get; set; }

        public string Numero { get; set; }

        public Guid IdPessoa { get; set; }

    }
}

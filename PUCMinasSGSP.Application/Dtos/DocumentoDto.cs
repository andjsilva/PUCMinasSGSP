using PUCMinasSGSP.Common.Enums;
using System;

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
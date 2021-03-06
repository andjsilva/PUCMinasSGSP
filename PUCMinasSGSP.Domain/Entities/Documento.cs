﻿using PUCMinasSGSP.Common.Enums;
using System;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Documento
    {
        public Guid Id { get; set; }

        public TipoDocumentoEnum Tipo { get; set; }

        public string Numero { get; set; }

        public Guid IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
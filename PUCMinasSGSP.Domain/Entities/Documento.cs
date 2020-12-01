using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Documento
    {
        public Guid Id { get; set; }

        public TipoDocumento Tipo { get; set; }

        public string Numero { get; set; }

        public Guid IdPessoa { get; set;}

        public Pessoa Pessoa { get; set; }
            
    }
}

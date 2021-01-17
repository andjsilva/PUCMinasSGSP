using PUCMinasSGSP.Common.Enums;
using System;

namespace PUCMinasSGSP.Application.Dtos
{
    public class TelefoneDto
    {
        public Guid Id { get; set; }

        public TipoTelefoneEnum Tipo { get; set; }

        public string DDI { get; set; }

        public string DDD { get; set; }

        public string Numero { get; set; }

        public bool Recado { get; set; }

        public string Complemento { get; set; }
    }
}
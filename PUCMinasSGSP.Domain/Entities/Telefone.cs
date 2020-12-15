using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Telefone
    {
        public Guid Id { get; set; }

        public TipoTelefoneEnum Tipo { get; set; }

        public string DDI { get; set; }

        public string DDD { get; set; }

        public string Numero { get; set; }

        public bool Recado { get; set; }

        public string Complemento { get; set; }

        public Guid? IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }

        public Guid? IdUnidadeAtendimento { get; set; }

        public UnidadeAtendimento UnidadeAtendimento { get; set; }
    }
}

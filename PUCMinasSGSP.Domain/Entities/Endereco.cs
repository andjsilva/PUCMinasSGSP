using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Endereco
    {
        public Guid Id { get; set; }

        public TipoLogradouro TipoLogradouro { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }
        
        public string Bairro { get; set; }
        
        public string Municipio { get; set; }

        public string Estado { get; set; }

        public double Latitude { get; set; }

        public double Longetude { get; set; }

        public Guid? IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }

        public Guid? IdUnidadeAtendimento { get; set; }

        public UnidadeAtendimento UnidadeAtendimento { get; set; }

  
    }
}

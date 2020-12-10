﻿using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class EnderecoDto
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
    }
}
﻿using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Dtos
{
    public class EmailDto
    {
        public Guid Id { get; set; }

        public TipoEmailEnum Tipo { get; set; }

        public string Endereco { get; set; }

        public StatusEnum Status { get; set; }
    }
}

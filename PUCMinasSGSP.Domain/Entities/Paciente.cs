﻿using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Paciente : Pessoa
    {
        public Status Status { get; set; }

        public Guid IdPessoa { get; set; }

    }
}
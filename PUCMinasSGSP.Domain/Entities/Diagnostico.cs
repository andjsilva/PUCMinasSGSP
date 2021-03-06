﻿using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Diagnostico
    {
        public Guid Id { get; set; }

        public TipoDiagnosticoEnum Tipo { get; set; }

        public Guid IdProntuario { get; set; }

        public virtual Prontuario Prontuario { get; set; }

        public DateTime Entrada { get; set; }

        public DateTime Saida { get; set; }

        public Guid IdMedico { get; set; }

        public virtual Funcionario Medico { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

        public virtual UnidadeAtendimento UnidadeAtendimento { get; set; }

        public virtual ICollection<DetalhesProntuario> DetalhesProntuario { get; set; }
    }
}
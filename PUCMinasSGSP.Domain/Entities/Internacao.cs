﻿using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Internacao
    {
        public Guid Id { get; set; }

        public Guid IdProntuario { get; set; }

        public virtual Prontuario Prontuario { get; set; }

        public DateTime Entrada { get; set; }

        public DateTime Saida { get; set; }

        public Guid IdLeito { get; set; }

        public virtual Leito Leito { get; set; }

        public bool Alta { get; set; }

        public Guid IdMedico { get; set; }

        public Funcionario Medico { get; set; }

        public virtual ICollection<DetalhesProntuario> DetalhesProntuario { get; set; }

       
    }
}
using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Application.Dtos
{
    public class DiagnosticoDto
    {
        public Guid Id { get; set; }

        public TipoDiagnosticoEnum Tipo { get; set; }

        public Guid IdProntuario { get; set; }

        public DateTime Entrada { get; set; }

        public DateTime Saida { get; set; }

        public Guid IdMedico { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

    }
}
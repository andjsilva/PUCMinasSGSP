using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Application.Dtos
{
    public class DetalhesProntuarioDto
    {
        public Guid Id { get; set; }

        public Guid IdProntuario { get; set; }

        public Guid? IdInternacao { get; set; }

        public Guid IdMedico { get; set; }

        public DateTime Solicitacao { get; set; }

        public DateTime Execucao { get; set; }

        public Guid IdProcedimento { get; set; }

        public Guid? IdDiagnostico { get; set; }

        public string Observacoes { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Entities
{
    public class DetalhesProntuario
    {
        public Guid Id { get; set; }

        public Guid IdProntuario { get; set; }

        public virtual Prontuario Prontuario { get; set; }

        public Guid IdInternacao { get; set; }

        public virtual Internacao Internacao { get; set; }

        public Guid IdMedico { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        public DateTime Solicitacao { get; set; }

        public DateTime Execucao { get; set; }

        public Guid IdProcedimento { get; set; }

        public virtual Procedimento Procedimento { get; set; }

        public Guid IdDiagnostico { get; set; }

        public Diagnostico Diagnostico { get; set; }

        public string Observacoes { get; set; }
    }
}

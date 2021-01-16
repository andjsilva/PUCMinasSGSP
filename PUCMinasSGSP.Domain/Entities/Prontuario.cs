using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Prontuario
    {
        public Guid Id { get; set; }

        public Guid IdPaciente { get; set; }

        public virtual Paciente Paciente { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public string TipoSanguinio { get; set; }

        public string RhSanguinio { get; set; }

        public string AlergiasMedicacao { get; set; }

        public string Doencas { get; set; }

        public string Observacoes { get; set; }

        public virtual ICollection<Internacao> Internacoes { get; set; }

    }
}

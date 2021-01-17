using System;
using System.Collections.Generic;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Prontuario
    {
        public Guid Id { get; set; }

        public virtual Paciente Paciente { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public string TipoSanguinio { get; set; }

        public string RhSanguinio { get; set; }

        public string AlergiasMedicacao { get; set; }

        public string Doencas { get; set; }

        public string Observacoes { get; set; }

        public virtual ICollection<Internacao> Internacoes { get; set; }

        public virtual ICollection<DetalhesProntuario> DetalhesProntuario { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}
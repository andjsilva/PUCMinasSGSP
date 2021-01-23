using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Application.Dtos
{
    public class ProntuarioDto
    {
        public Guid Id { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public string TipoSanguinio { get; set; }

        public string RhSanguinio { get; set; }

        public string AlergiasMedicacao { get; set; }

        public string Doencas { get; set; }

        public string Observacoes { get; set; }

    }
}
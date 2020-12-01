using System;
using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Agenda
    {
        public Guid Id { get; set; }

        public TipoAgenda Tipo { get; set; }

        public DiaSemana DiaSemana { get; set; }

        public DateTime Entrada { get; set; }

        public DateTime Saida { get; set; }

        public bool Disponivel { get; set; }

        public Guid? IdPaciente { get; set; }

        public Paciente Paciente { get; set; }

        public Guid? IdFuncionario { get; set; }

        public Guid Funcionario { get; set; }

    }
}

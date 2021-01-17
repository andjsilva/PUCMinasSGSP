using System;

namespace PUCMinasSGSP.Domain.Entities
{
    public class EspecialidadeFuncionario
    {
        public Guid Id { get; set; }

        public Guid IdEspecialidade { get; set; }

        public virtual Especialidade Especialidade { get; set; }

        public Guid IdFuncionario { get; set; }

        public virtual Funcionario Funcionario { get; set; }
    }
}
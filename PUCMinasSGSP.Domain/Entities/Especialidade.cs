using System;
namespace PUCMinasSGSP.Domain.Entities
{
    public class Especialidade
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Guid IdFuncionario { get; set; }

        public Guid Funcionario { get; set; }
    }
}

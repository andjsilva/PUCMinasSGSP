using System;
namespace PUCMinasSGSP.Domain.Entities
{
    public class Cargo
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public Guid IdFuncionario { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}

using PUCMinasSGSP.Common.Enums;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Usuario : Pessoa
    {
        public string IdUsuario { get; set; }

        public string Senha { get; set; }

        public StatusEnum Status { get; set; }

        public string Email { get; set; }
    }
}
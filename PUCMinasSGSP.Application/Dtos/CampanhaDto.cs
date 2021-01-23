using System;

namespace PUCMinasSGSP.Application.Dtos
{
    public class CampanhaDto
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public Guid IdUnidadeAtendimento { get; set; }

    }
}
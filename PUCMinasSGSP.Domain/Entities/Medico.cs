using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Entities
{
    public class Medico : Funcionario
    {
        public virtual ICollection<Internacao> Internacoes { get; set; }
    }
}

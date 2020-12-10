using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServicePaciente
    {
        void Add(PacienteDto pacienteDto);

        void Update(PacienteDto pacienteDto);

        void Remove(PacienteDto pacienteDto);

        IEnumerable<PacienteDto> GetAll();

        PacienteDto GetById(Guid id);
    }
}

using PUCMinasSGSP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Application.Interfaces
{
    public interface IApplicationServicePaciente
    {
        PacienteDto Add(PacienteDto pacienteDto);

        PacienteDto Update(Guid id, PacienteDto pacienteDto);

        void Remove(Guid id, PacienteDto pacienteDto);

        IEnumerable<PacienteDto> GetAll();

        PacienteDto GetById(Guid id);
    }
}

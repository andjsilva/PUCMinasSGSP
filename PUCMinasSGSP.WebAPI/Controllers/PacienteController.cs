using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PUCMinasSGSP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IApplicationServicePaciente applicationServicePaciente;

        public PacienteController(IApplicationServicePaciente applicationServicePaciente)
        {
            this.applicationServicePaciente = applicationServicePaciente;
        }
        

        // GET: api/<PacienteController>
        [HttpGet]
        public ActionResult<IEnumerable<PacienteDto>>Get()
        {
            return Ok(this.applicationServicePaciente.GetAll());
        }

     
        // GET api/<PacienteController>/5
        [HttpGet("{id}")]
        public ActionResult<PacienteDto> Get(Guid id)
        {
            return Ok(this.applicationServicePaciente.GetById(id));
        }

        // POST api/<PacienteController>
        [HttpPost]
        public ActionResult Post([FromBody] PacienteDto pacienteDto)
        {
            try
            {
                if (pacienteDto == null)
                    return NotFound();

                this.applicationServicePaciente.Add(pacienteDto);
                return Ok("Paciente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // PUT api/<PacienteController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] PacienteDto pacienteDto)
        {
            try
            {
                if (this.applicationServicePaciente.GetById(id) == null)
                    return NotFound("Paciente não cadastrado!");

                this.applicationServicePaciente.Update(pacienteDto);
                return Ok("Cadastro do paciente atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // DELETE api/<PacienteController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id, [FromBody] PacienteDto pacienteDto)
        {
            try
            {
                if (this.applicationServicePaciente.GetById(id) == null)
                    return NotFound("Paciente não cadastrado!");

                this.applicationServicePaciente.Update(pacienteDto);
                return Ok("Cadastro do paciente excluido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}

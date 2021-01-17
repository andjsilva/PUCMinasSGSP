using Microsoft.AspNetCore.Mvc;
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<IEnumerable<PacienteDto>>> GetAll()
        {
            return Ok(await this.applicationServicePaciente.GetAllAsync());
        }

        // GET api/<PacienteController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteDto>> Get(Guid id)
        {
            return Ok(await this.applicationServicePaciente.GetByIdAsync(id));
        }

        // POST api/<PacienteController>
        [HttpPost]
        public async Task<ActionResult<PacienteDto>> Post([FromBody] PacienteDto pacienteDto)
        {
            try
            {
                return await this.applicationServicePaciente.AddAsync(pacienteDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<PacienteController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<PacienteDto>> Put(Guid id, [FromBody] PacienteDto pacienteDto)
        {
            try
            {
                return await this.applicationServicePaciente.UpdateAsync(id, pacienteDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<PacienteController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServicePaciente.RemoveAsync(id))
                    return Ok("Registro excluído com sucesso...");

                return NotFound("Registro não encontrado...");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
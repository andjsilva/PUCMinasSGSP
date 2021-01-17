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
    public class UnidadeAtendimentoController : ControllerBase
    {
        private readonly IApplicationServiceUnidadeAtendimento applicationServiceUnidadeAtendimento;

        public UnidadeAtendimentoController(IApplicationServiceUnidadeAtendimento applicationServiceUnidadeAtendimento)
        {
            this.applicationServiceUnidadeAtendimento = applicationServiceUnidadeAtendimento;
        }

        // GET: api/<UnidadeAtendimentoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadeAtendimentoDto>>> GetAll()
        {
            return Ok(await this.applicationServiceUnidadeAtendimento.GetAllAsync());
        }

        // GET api/<UnidadeAtendimentoController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceUnidadeAtendimento.GetByIdAsync(id));
        }

        // POST api/<UnidadeAtendimentoController>
        [HttpPost]
        public async Task<ActionResult<UnidadeAtendimentoDto>> Post([FromBody] UnidadeAtendimentoDto unidadeAtendimentoDto)
        {
            try
            {
                return await this.applicationServiceUnidadeAtendimento.AddAsync(unidadeAtendimentoDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<UnidadeAtendimentoController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<UnidadeAtendimentoDto>> Put(Guid id, [FromBody] UnidadeAtendimentoDto unidadeAtendimentoDto)
        {
            try
            {
                return await this.applicationServiceUnidadeAtendimento.UpdateAsync(id, unidadeAtendimentoDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<UnidadeAtendimentoController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceUnidadeAtendimento.RemoveAsync(id))
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
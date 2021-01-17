using Microsoft.AspNetCore.Mvc;
using PUCMinasSGSP.Application.Dtos;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Common.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PUCMinasSGSP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoneController : ControllerBase
    {
        private readonly IApplicationServiceTelefone applicationServiceTelefone;

        public TelefoneController(IApplicationServiceTelefone applicationServiceTelefone)
        {
            this.applicationServiceTelefone = applicationServiceTelefone;
        }

        // GET: api/<TelefoneController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelefoneDto>>> GetAll()
        {
            return Ok(await this.applicationServiceTelefone.GetAllAsync());
        }

        // GET api/<TelefoneController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<TelefoneDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceTelefone.GetByIdAsync(id));
        }

        // POST api/<TelefoneController>
        [HttpPost("paciente/{id}")]
        public async Task<ActionResult<TelefoneDto>> PostPaciente(EntidadeEnum entidade, Guid idEntidade, [FromBody] TelefoneDto telefoneDto)
        {
            try
            {
                return await this.applicationServiceTelefone.AddAsync(entidade, idEntidade, telefoneDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<TelefoneController>
        [HttpPost("funcionario/{id}")]
        public async Task<ActionResult<TelefoneDto>> PostFuncionario(EntidadeEnum entidade, Guid idEntidade, [FromBody] TelefoneDto telefoneDto)
        {
            try
            {
                return await this.applicationServiceTelefone.AddAsync(entidade, idEntidade, telefoneDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<TelefoneController>
        [HttpPost("unidade_atendimento/{id}")]
        public async Task<ActionResult<TelefoneDto>> PostUnidadeAtendimento(EntidadeEnum entidade, Guid idEntidade, [FromBody] TelefoneDto telefoneDto)
        {
            try
            {
                return await this.applicationServiceTelefone.AddAsync(entidade, idEntidade, telefoneDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<TelefoneController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<TelefoneDto>> Put(Guid id, [FromBody] TelefoneDto telefoneDto)
        {
            try
            {
                return await this.applicationServiceTelefone.UpdateAsync(id, telefoneDto);
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
                if (await this.applicationServiceTelefone.RemoveAsync(id))
                    return Ok("Registro excluído com sucesso...");

                return NotFound("Registro não encontrado....");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
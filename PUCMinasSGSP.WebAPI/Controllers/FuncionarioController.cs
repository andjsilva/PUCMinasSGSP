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
    public class FuncionarioController : ControllerBase
    {
        private readonly IApplicationServiceFuncionario applicationServiceFuncionario;

        public FuncionarioController(IApplicationServiceFuncionario applicationServiceFuncionario)
        {
            this.applicationServiceFuncionario = applicationServiceFuncionario;
        }

        // GET: api/<FuncionarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PacienteDto>>> GetAll()
        {
            return Ok(await this.applicationServiceFuncionario.GetAllAsync());
        }

        // GET api/<FuncionarioController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceFuncionario.GetByIdAsync(id));
        }

        // POST api/<FuncionarioController>
        [HttpPost]
        public async Task<ActionResult<FuncionarioDto>> Post([FromBody] FuncionarioDto funcionarioDto)
        {
            try
            {
                return await this.applicationServiceFuncionario.AddAsync(funcionarioDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<FuncionarioController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<FuncionarioDto>> Put(Guid id, [FromBody] FuncionarioDto funcionarioDto)
        {
            try
            {
                return await this.applicationServiceFuncionario.UpdateAsync(id, funcionarioDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<FuncionarioController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceFuncionario.RemoveAsync(id))
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
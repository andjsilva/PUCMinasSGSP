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
    public class EnderecoController : ControllerBase
    {
        private readonly IApplicationServiceEndereco applicationServiceEndereco;

        public EnderecoController(IApplicationServiceEndereco applicationServiceEndereco)
        {
            this.applicationServiceEndereco = applicationServiceEndereco;
        }
        

        // GET: api/<EnderecoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnderecoDto>>> GetAll()
        {
            return Ok(await this.applicationServiceEndereco.GetAllAsync());
        }

     
        // GET api/<EnderecoController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<EnderecoDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceEndereco.GetByIdAsync(id));
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public async Task<ActionResult<EnderecoDto>> Post([FromBody] EnderecoDto EnderecoDto)
        {
            try
            {
                return await this.applicationServiceEndereco.AddAsync(EnderecoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // PUT api/<EnderecoController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<EnderecoDto>> Put(Guid id, [FromBody] EnderecoDto EnderecoDto)
        {
            try
            {
                return await this.applicationServiceEndereco.UpdateAsync(id, EnderecoDto);
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
                if ( await this.applicationServiceEndereco.RemoveAsync(id))
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

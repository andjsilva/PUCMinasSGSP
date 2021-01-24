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
    public class ProntuarioController : ControllerBase
    {
        private readonly IApplicationServiceProntuario applicationServiceProntuario;

        public ProntuarioController(IApplicationServiceProntuario applicationServiceProntuario)
        {
            this.applicationServiceProntuario = applicationServiceProntuario;
        }

        // GET: api/<ProntuarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProntuarioDto>>> GetAll()
        {
            return Ok(await this.applicationServiceProntuario.GetAllAsync());
        }

        // GET api/<ProntuarioController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<ProntuarioDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceProntuario.GetByIdAsync(id));
        }

        // POST api/<ProntuarioController>
        [HttpPost]
        public async Task<ActionResult<ProntuarioDto>> Post([FromBody] ProntuarioDto prontuarioDto)
        {
            try
            {
                return await this.applicationServiceProntuario.AddAsync(prontuarioDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<ProntuarioController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<ProntuarioDto>> Put(Guid id, [FromBody] ProntuarioDto prontuarioDto)
        {
            try
            {
                return await this.applicationServiceProntuario.UpdateAsync(id, prontuarioDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<ProntuarioController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceProntuario.RemoveAsync(id))
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
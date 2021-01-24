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
    public class LeitoController : ControllerBase
    {
        private readonly IApplicationServiceLeito applicationServiceLeito;

        public LeitoController(IApplicationServiceLeito applicationServiceLeito)
        {
            this.applicationServiceLeito = applicationServiceLeito;
        }

        // GET: api/<LeitoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeitoDto>>> GetAll()
        {
            return Ok(await this.applicationServiceLeito.GetAllAsync());
        }

        // GET api/<LeitoController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<LeitoDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceLeito.GetByIdAsync(id));
        }

        // POST api/<LeitoController>
        [HttpPost]
        public async Task<ActionResult<LeitoDto>> Post([FromBody] LeitoDto leitoDto)
        {
            try
            {
                return await this.applicationServiceLeito.AddAsync(leitoDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<LeitoController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<LeitoDto>> Put(Guid id, [FromBody] LeitoDto leitoDto)
        {
            try
            {
                return await this.applicationServiceLeito.UpdateAsync(id, leitoDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<LeitoController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceLeito.RemoveAsync(id))
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
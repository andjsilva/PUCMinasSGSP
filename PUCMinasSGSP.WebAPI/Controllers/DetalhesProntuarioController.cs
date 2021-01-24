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
    public class DetalhesProntuarioController : ControllerBase
    {
        private readonly IApplicationServiceDetalhesProntuario applicationServiceDetalhesProntuario;

        public DetalhesProntuarioController(IApplicationServiceDetalhesProntuario applicationServiceDetalhesProntuario)
        {
            this.applicationServiceDetalhesProntuario = applicationServiceDetalhesProntuario;
        }

        // GET: api/<DetalhesProntuarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalhesProntuarioDto>>> GetAll()
        {
            return Ok(await this.applicationServiceDetalhesProntuario.GetAllAsync());
        }

        // GET api/<DetalhesProntuarioController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalhesProntuarioDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceDetalhesProntuario.GetByIdAsync(id));
        }

        // POST api/<DetalhesProntuarioController>
        [HttpPost]
        public async Task<ActionResult<DetalhesProntuarioDto>> Post([FromBody] DetalhesProntuarioDto detalhesProntuarioDto)
        {
            try
            {
                return await this.applicationServiceDetalhesProntuario.AddAsync(detalhesProntuarioDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<DetalhesProntuarioController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<DetalhesProntuarioDto>> Put(Guid id, [FromBody] DetalhesProntuarioDto detalhesProntuarioDto)
        {
            try
            {
                return await this.applicationServiceDetalhesProntuario.UpdateAsync(id, detalhesProntuarioDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<DetalhesProntuarioController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceDetalhesProntuario.RemoveAsync(id))
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
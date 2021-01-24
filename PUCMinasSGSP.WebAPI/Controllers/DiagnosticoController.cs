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
    public class DiagnosticoController : ControllerBase
    {
        private readonly IApplicationServiceDiagnostico applicationServiceDiagnostico;

        public DiagnosticoController(IApplicationServiceDiagnostico applicationServiceDiagnostico)
        {
            this.applicationServiceDiagnostico = applicationServiceDiagnostico;
        }

        // GET: api/<DiagnosticoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiagnosticoDto>>> GetAll()
        {
            return Ok(await this.applicationServiceDiagnostico.GetAllAsync());
        }

        // GET api/<DiagnosticoController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<DiagnosticoDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceDiagnostico.GetByIdAsync(id));
        }

        // POST api/<DiagnosticoController>
        [HttpPost]
        public async Task<ActionResult<DiagnosticoDto>> Post([FromBody] DiagnosticoDto diagnosticoDto)
        {
            try
            {
                return await this.applicationServiceDiagnostico.AddAsync(diagnosticoDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<DiagnosticoController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<DiagnosticoDto>> Put(Guid id, [FromBody] DiagnosticoDto diagnosticoDto)
        {
            try
            {
                return await this.applicationServiceDiagnostico.UpdateAsync(id, diagnosticoDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<DiagnosticoController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceDiagnostico.RemoveAsync(id))
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
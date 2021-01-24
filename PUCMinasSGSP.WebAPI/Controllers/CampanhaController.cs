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
    public class CampanhaController : ControllerBase
    {
        private readonly IApplicationServiceCampanha applicationServiceCampanha;

        public CampanhaController(IApplicationServiceCampanha applicationServiceCampanha)
        {
            this.applicationServiceCampanha = applicationServiceCampanha;
        }

        // GET: api/<CampanhaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampanhaDto>>> GetAll()
        {
            return Ok(await this.applicationServiceCampanha.GetAllAsync());
        }

        // GET api/<CampanhaController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<CampanhaDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceCampanha.GetByIdAsync(id));
        }

        // POST api/<CampanhaController>
        [HttpPost]
        public async Task<ActionResult<CampanhaDto>> Post([FromBody] CampanhaDto campanhaDto)
        {
            try
            {
                return await this.applicationServiceCampanha.AddAsync(campanhaDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<CampanhaController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<CampanhaDto>> Put(Guid id, [FromBody] CampanhaDto campanhaDto)
        {
            try
            {
                return await this.applicationServiceCampanha.UpdateAsync(id, campanhaDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<CampanhaController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceCampanha.RemoveAsync(id))
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
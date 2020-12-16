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
    public class EstoqueController : ControllerBase
    {
        private readonly IApplicationServiceEstoque applicationServiceEstoque;

        public EstoqueController(IApplicationServiceEstoque applicationServiceEstoque)
        {
            this.applicationServiceEstoque = applicationServiceEstoque;
        }
        

        // GET: api/<EstoqueController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstoqueDto>>> GetAll()
        {
            return Ok(await this.applicationServiceEstoque.GetAllAsync());
        }

     
        // GET api/<EstoqueController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<EstoqueDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceEstoque.GetByIdAsync(id));
        }

        // POST api/<EstoqueController>
        [HttpPost]
        public async Task<ActionResult<EstoqueDto>> Post([FromBody] EstoqueDto estoqueDto)
        {
            try
            {
                return await this.applicationServiceEstoque.AddAsync(estoqueDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // PUT api/<EstoqueController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<EstoqueDto>> Put(Guid id, [FromBody] EstoqueDto estoqueDto)
        {
            try
            {
                return await this.applicationServiceEstoque.UpdateAsync(id, estoqueDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // DELETE api/<EstoqueController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceEstoque.RemoveAsync(id))
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

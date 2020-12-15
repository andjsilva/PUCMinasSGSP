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
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }
        

        // GET: api/<ProdutoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetAll()
        {
            return Ok(await this.applicationServiceProduto.GetAllAsync());
        }

     
        // GET api/<ProdutoController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceProduto.GetByIdAsync(id));
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<ActionResult<ProdutoDto>> Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                return await this.applicationServiceProduto.AddAsync(produtoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // PUT api/<ProdutoController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<ProdutoDto>> Put(Guid id, [FromBody] ProdutoDto produtoDto)
        {
            try
            {
                return await this.applicationServiceProduto.UpdateAsync(id, produtoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // DELETE api/<ProdutoController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceProduto.RemoveAsync(id))
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

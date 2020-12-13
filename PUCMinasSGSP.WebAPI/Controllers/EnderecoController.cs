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
        public ActionResult<IEnumerable<EnderecoDto>>Get()
        {
            return Ok(this.applicationServiceEndereco.GetAll());
        }

     
        // GET api/<EnderecoController>/
        [HttpGet("{id}")]
        public ActionResult<EnderecoDto> Get(Guid id)
        {
            return Ok(this.applicationServiceEndereco.GetById(id));
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public ActionResult<EnderecoDto> Post([FromBody] EnderecoDto EnderecoDto)
        {
            try
            {
                return this.applicationServiceEndereco.Add(EnderecoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // PUT api/<EnderecoController>/id
        [HttpPut("{id}")]
        public ActionResult<EnderecoDto> Put(Guid id, [FromBody] EnderecoDto EnderecoDto)
        {
            try
            {
                return this.applicationServiceEndereco.Update(id, EnderecoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

         // DELETE api/<PacienteController>/id
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                if (this.applicationServiceEndereco.Remove(id))
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

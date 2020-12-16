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
    public class CargoController : ControllerBase
    {
        private readonly IApplicationServiceCargo applicationServiceCargo;

        public CargoController(IApplicationServiceCargo applicationServiceCargo)
        {
            this.applicationServiceCargo = applicationServiceCargo;
        }
        

        // GET: api/<CargoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CargoDto>>> GetAll()
        {
            return Ok(await this.applicationServiceCargo.GetAllAsync());
        }

     
        // GET api/<CargoController>/
        [HttpGet("{id}")]
        public async Task<ActionResult<CargoDto>> Get(Guid id)
        {
            return Ok(await this.applicationServiceCargo.GetByIdAsync(id));
        }

        // POST api/<CargoController>
        [HttpPost]
        public async Task<ActionResult<CargoDto>> Post([FromBody] CargoDto cargoDto)
        {
            try
            {
                return await this.applicationServiceCargo.AddAsync(cargoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // PUT api/<CargoController>/id
        [HttpPut("{id}")]
        public async Task<ActionResult<CargoDto>> Put(Guid id, [FromBody] CargoDto cargoDto)
        {
            try
            {
                return await this.applicationServiceCargo.UpdateAsync(id, cargoDto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // DELETE api/<CargoController>/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (await this.applicationServiceCargo.RemoveAsync(id))
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

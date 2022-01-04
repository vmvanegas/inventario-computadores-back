using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Mispollos.Configuration;
using Mispollos.Domain.Contracts.Services;
using Mispollos.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mispollos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseDeMaderaController : ControllerBase
    {
        private readonly IBaseDeMaderaService _service;

        public BaseDeMaderaController(IBaseDeMaderaService service)
        {
            _service = service;
        }

        // Metodo traer lista de BaseDeMaderaes

        // GET: api/<BaseDeMaderaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetBasesDeMadera();
            return Ok(result);
        }

        // GET: api/<BaseDeMaderaController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetBasesDeMaderaPaged(page, search);
            return Ok(result);
        }

        // Traer un BaseDeMadera por id
        // GET api/<BaseDeMaderaController>/5
        [HttpGet("{id}")]
        public async Task<BaseDeMadera> Get(Guid id)
        {
            return await _service.GetBaseDeMaderaById(id);
        }

        // Crear BaseDeMadera
        // POST api/<BaseDeMaderaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BaseDeMadera BaseDeMadera)
        {
            var result = await _service.CreateBaseDeMadera(BaseDeMadera);
            return Ok(result);
        }

        // Actualizar BaseDeMadera
        // PUT api/<BaseDeMaderaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(BaseDeMadera BaseDeMadera)
        {
            await _service.UpdateBaseDeMadera(BaseDeMadera);

            return Ok();
        }

        // Borrar BaseDeMadera
        // DELETE api/<BaseDeMaderaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteBaseDeMadera(id);
            return Ok();
        }
    }
}
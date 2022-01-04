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
    public class LaptopController : ControllerBase
    {
        private readonly ILaptopService _service;

        public LaptopController(ILaptopService service)
        {
            _service = service;
        }

        // Metodo traer lista de Laptopes

        // GET: api/<LaptopController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetLaptops();
            return Ok(result);
        }

        // GET: api/<LaptopController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetLaptopsPaged(page, search);
            return Ok(result);
        }

        // Traer un Laptop por id
        // GET api/<LaptopController>/5
        [HttpGet("{id}")]
        public async Task<Laptop> Get(Guid id)
        {
            return await _service.GetLaptopById(id);
        }

        // Crear Laptop
        // POST api/<LaptopController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Laptop Laptop)
        {
            var result = await _service.CreateLaptop(Laptop);
            return Ok(result);
        }

        // Actualizar Laptop
        // PUT api/<LaptopController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Laptop Laptop)
        {
            await _service.UpdateLaptop(Laptop);

            return Ok();
        }

        // Borrar Laptop
        // DELETE api/<LaptopController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteLaptop(id);
            return Ok();
        }
    }
}
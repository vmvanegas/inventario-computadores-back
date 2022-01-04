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
    public class DiademaController : ControllerBase
    {
        private readonly IDiademaService _service;

        public DiademaController(IDiademaService service)
        {
            _service = service;
        }

        // Metodo traer lista de Diademas

        // GET: api/<DiademaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetDiademas();
            return Ok(result);
        }

        // GET: api/<DiademaController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetDiademasPaged(page, search);
            return Ok(result);
        }

        // Traer un Diadema por id
        // GET api/<DiademaController>/5
        [HttpGet("{id}")]
        public async Task<Diadema> Get(Guid id)
        {
            return await _service.GetDiademaById(id);
        }

        // Crear Diadema
        // POST api/<DiademaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Diadema Diadema)
        {
            var result = await _service.CreateDiadema(Diadema);
            return Ok(result);
        }

        // Actualizar Diadema
        // PUT api/<DiademaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Diadema Diadema)
        {
            await _service.UpdateDiadema(Diadema);

            return Ok();
        }

        // Borrar Diadema
        // DELETE api/<DiademaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteDiadema(id);
            return Ok();
        }
    }
}
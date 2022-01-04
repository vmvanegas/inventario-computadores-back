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
    public class TecladoController : ControllerBase
    {
        private readonly ITecladoService _service;

        public TecladoController(ITecladoService service)
        {
            _service = service;
        }

        // Metodo traer lista de Teclados

        // GET: api/<TecladoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetTeclados();
            return Ok(result);
        }

        // GET: api/<TecladoController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetTecladosPaged(page, search);
            return Ok(result);
        }

        // Traer un Teclado por id
        // GET api/<TecladoController>/5
        [HttpGet("{id}")]
        public async Task<Teclado> Get(Guid id)
        {
            return await _service.GetTecladoById(id);
        }

        // Crear Teclado
        // POST api/<TecladoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Teclado Teclado)
        {
            var result = await _service.CreateTeclado(Teclado);
            return Ok(result);
        }

        // Actualizar Teclado
        // PUT api/<TecladoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Teclado Teclado)
        {
            await _service.UpdateTeclado(Teclado);

            return Ok();
        }

        // Borrar Teclado
        // DELETE api/<TecladoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteTeclado(id);
            return Ok();
        }
    }
}
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
    public class CargadorController : ControllerBase
    {
        private readonly ICargadorService _service;

        public CargadorController(ICargadorService service)
        {
            _service = service;
        }

        // Metodo traer lista de Cargadores

        // GET: api/<CargadorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetCargadores();
            return Ok(result);
        }

        // GET: api/<CargadorController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetCargadoresPaged(page, search);
            return Ok(result);
        }

        // Traer un Cargador por id
        // GET api/<CargadorController>/5
        [HttpGet("{id}")]
        public async Task<Cargador> Get(Guid id)
        {
            return await _service.GetCargadorById(id);
        }

        // Crear Cargador
        // POST api/<CargadorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cargador Cargador)
        {
            var result = await _service.CreateCargador(Cargador);
            return Ok(result);
        }

        // Actualizar Cargador
        // PUT api/<CargadorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Cargador Cargador)
        {
            await _service.UpdateCargador(Cargador);

            return Ok();
        }

        // Borrar Cargador
        // DELETE api/<CargadorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteCargador(id);
            return Ok();
        }
    }
}
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
    public class CableVGAController : ControllerBase
    {
        private readonly ICableVGAService _service;

        public CableVGAController(ICableVGAService service)
        {
            _service = service;
        }

        // Metodo traer lista de CableVGAes

        // GET: api/<CableVGAController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetCablesVGA();
            return Ok(result);
        }

        // GET: api/<CableVGAController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetCablesVGAPaged(page, search);
            return Ok(result);
        }

        // Traer un CableVGA por id
        // GET api/<CableVGAController>/5
        [HttpGet("{id}")]
        public async Task<CableVGA> Get(Guid id)
        {
            return await _service.GetCableVGAById(id);
        }

        // Crear CableVGA
        // POST api/<CableVGAController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CableVGA CableVGA)
        {
            var result = await _service.CreateCableVGA(CableVGA);
            return Ok(result);
        }

        // Actualizar CableVGA
        // PUT api/<CableVGAController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(CableVGA CableVGA)
        {
            await _service.UpdateCableVGA(CableVGA);

            return Ok();
        }

        // Borrar CableVGA
        // DELETE api/<CableVGAController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteCableVGA(id);
            return Ok();
        }
    }
}
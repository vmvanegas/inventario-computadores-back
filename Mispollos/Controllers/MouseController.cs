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
    public class MouseController : ControllerBase
    {
        private readonly IMouseService _service;

        public MouseController(IMouseService service)
        {
            _service = service;
        }

        // Metodo traer lista de Mouses

        // GET: api/<MouseController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetMouses();
            return Ok(result);
        }

        // GET: api/<MouseController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetMousesPaged(page, search);
            return Ok(result);
        }

        // Traer un Mouse por id
        // GET api/<MouseController>/5
        [HttpGet("{id}")]
        public async Task<Mouse> Get(Guid id)
        {
            return await _service.GetMouseById(id);
        }

        // Crear Mouse
        // POST api/<MouseController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Mouse Mouse)
        {
            var result = await _service.CreateMouse(Mouse);
            return Ok(result);
        }

        // Actualizar Mouse
        // PUT api/<MouseController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Mouse Mouse)
        {
            await _service.UpdateMouse(Mouse);

            return Ok();
        }

        // Borrar Mouse
        // DELETE api/<MouseController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteMouse(id);
            return Ok();
        }
    }
}
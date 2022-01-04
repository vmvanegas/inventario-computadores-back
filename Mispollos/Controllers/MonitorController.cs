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
    public class MonitorController : ControllerBase
    {
        private readonly IMonitorService _service;

        public MonitorController(IMonitorService service)
        {
            _service = service;
        }

        // Metodo traer lista de Monitors

        // GET: api/<MonitorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetMonitors();
            return Ok(result);
        }

        // GET: api/<MonitorController>/1
        [HttpGet("p/{page}")]
        public async Task<IActionResult> Get(int page, string search = null)
        {
            var result = await _service.GetMonitorsPaged(page, search);
            return Ok(result);
        }

        // Traer un Monitor por id
        // GET api/<MonitorController>/5
        [HttpGet("{id}")]
        public async Task<Monitor> Get(Guid id)
        {
            return await _service.GetMonitorById(id);
        }

        // Crear Monitor
        // POST api/<MonitorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Monitor Monitor)
        {
            var result = await _service.CreateMonitor(Monitor);
            return Ok(result);
        }

        // Actualizar Monitor
        // PUT api/<MonitorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Monitor Monitor)
        {
            await _service.UpdateMonitor(Monitor);

            return Ok();
        }

        // Borrar Monitor
        // DELETE api/<MonitorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteMonitor(id);
            return Ok();
        }
    }
}
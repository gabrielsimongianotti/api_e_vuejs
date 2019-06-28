using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private IPacienteService _pacienteService;
        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_pacienteService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var pacite = _pacienteService.FindById(id);
            if (pacite == null) return NotFound(id);
            return Ok(pacite);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Paciente paciente)
        {
            if (paciente == null) return BadRequest();
            return new ObjectResult(_pacienteService.Create(paciente));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Paciente paciente)
        {
            if (paciente == null) return BadRequest();
            return new ObjectResult(_pacienteService.Update(paciente));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pacienteService.Delete(id);
            return NoContent();
        }
    }
}

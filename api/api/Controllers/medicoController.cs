using api.Model;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/medico")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private IMedicoService _medicoService;
        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }
        // GET api/medico
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_medicoService.FindAll());
        }

        // GET api/medico/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var medico = _medicoService.FindById(id);
            if (medico == null) return NotFound();
            return Ok(medico);
        }

        // POST api/medico
        [HttpPost]
        public IActionResult Post([FromBody] Medico medico)
        {
            if (medico == null) return BadRequest();
            return new ObjectResult(_medicoService.Create(medico));
        }

        // PUT api/medico/5
        [HttpPut("{id}")]
        public IActionResult Put(int crm,[FromBody] Medico medico)
        {
            if (medico == null) return BadRequest();
            return new ObjectResult(_medicoService.Update(medico));
        }

        // DELETE api/medico/5
        [HttpDelete("{crm}")]
        public IActionResult Delete(int crm)
        {
            _medicoService.Delete(crm);
            return NoContent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/frequencias")]
    [ApiController]
    public class FrequenciasController : ControllerBase
    {
        private IFrequenciasService _frequenciasService;
        public FrequenciasController(IFrequenciasService frequenciasService)
        {
            _frequenciasService = frequenciasService;
        }
         //GET api/values
         [HttpGet]
          public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_frequenciasService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var frequencias = _frequenciasService.FindById(id);
            if (frequencias == null) return NotFound();
            return Ok(frequencias);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Frequencias frequencias)
        {
            if (frequencias == null) return BadRequest();
            return new ObjectResult(_frequenciasService.Create(frequencias));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Frequencias frequencias)
        {
            if (frequencias == null) return BadRequest();
            return new ObjectResult(_frequenciasService.Update(frequencias));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _frequenciasService.Delete(id);
            return NoContent();
        }
    }
}

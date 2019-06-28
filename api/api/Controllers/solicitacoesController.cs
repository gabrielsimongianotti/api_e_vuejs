using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/solicitacoes")]
    [ApiController]
    public class solicitacoesController : ControllerBase
    {
        private ISolicitacoesService _solicitacoesService;
        public solicitacoesController(ISolicitacoesService solicitacoesService)
        {
            _solicitacoesService = solicitacoesService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_solicitacoesService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var solicitacoes = _solicitacoesService.FindById(id);
            if (solicitacoes == null) return NotFound();
            return Ok(solicitacoes);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Solicitacoes solicitacoes)
        {
            if (solicitacoes == null) return BadRequest();
            return new ObjectResult(_solicitacoesService.Create(solicitacoes));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Solicitacoes solicitacoes)
        {
            if (solicitacoes == null) return BadRequest();
            return new ObjectResult(_solicitacoesService.Update(solicitacoes));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _solicitacoesService.Delete(id);
            return NoContent();
        }
    }
}

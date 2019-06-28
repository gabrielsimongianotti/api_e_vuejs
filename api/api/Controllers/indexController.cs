using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class indexController : ControllerBase
    {
        // GET: api/index
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "rotas",
                "frequencias : https://localhost:44365/api/frequencias",
                "medico : https://localhost:44365/api/medico",
                "paciente : https://localhost:44365/api/paciente",
                "solicitacoes : https://localhost:44365/api/solicitacoes",
            };
        }


    }
}

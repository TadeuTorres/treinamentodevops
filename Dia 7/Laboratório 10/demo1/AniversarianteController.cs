using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication51.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AniversarianteController : ControllerBase
    {
        private readonly ILogger<AniversarianteController> _logger;

        public AniversarianteController(ILogger<AniversarianteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return "Maria do Carmo";
            yield return "João Oliveira";
            yield return "Carla Silva";
            yield return "Carlos Augusto";
            yield return "Regina Miertschink";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InternetBanking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        public ContaCorrenteController()
        {

        }

        [HttpGet]
        public IEnumerable<ContaCorrente> Get()
        {
            DataBaseService.Init();

            return DataBaseService.All();
        }
    }
}

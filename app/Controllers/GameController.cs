using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SecretHiplerServer.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        // GET /api/game
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("/api/game/start")]
        public string Post([FromBody] object body) {
            Console.WriteLine(body);
            return body.ToString();
        }
    }
}

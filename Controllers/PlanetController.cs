using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testApi.data;

namespace testApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetController : ControllerBase
    {
           private readonly ILogger<PlanetController> _logger;
           private readonly PlanetContext _context;
           
           public PlanetController(ILogger<PlanetController> logger, PlanetContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Planet> Get()
        {
            Console.WriteLine("retrieving all  " + _context.Planets.First().name);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Planet
            {
                name = "planet" + index
            })
            .ToArray();
        }
    }
}
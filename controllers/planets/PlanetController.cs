using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testApi.data;

namespace testApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetRepository _repository;

        public PlanetController(IPlanetRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{planet}")]
        public ActionResult<Planet> GetPlanet(string planet)
        {
            Planet result = _repository.GetPlanetByName(planet);
            if (result == null)
            {
                return BadRequest("Planet does not exist.");
            }
            return result;
        }

        [HttpGet("all")]
        public List<Planet> GetAllPlanet()
        {
            return _repository.GetPlanets();
        }
    }
}
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
           private readonly IPlanetRepository _repository;
           
           public PlanetController(IPlanetRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{planet}")]
        public Planet GetPlanet(string planet)
        {
            return _repository.GetPlanetByName(planet);
        }

        [HttpGet("all")]
        public List<Planet> GetAllPlanet()
        {
            return _repository.GetPlanets();
        }
    }
}
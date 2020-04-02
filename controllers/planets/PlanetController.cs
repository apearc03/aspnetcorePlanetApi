using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using testApi.data;

namespace testApi.Controllers.planets
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
        public ActionResult<Planet> getPlanet(string planet)
        {
            Planet result = _repository.getPlanetByName(formatRequestPlanet(planet));
            if (result == null)
            {
                return BadRequest(new { errorMessage = "Planet does not exist." });
            }
            return result;
        }

        [HttpGet("all")]
        public ActionResult<List<Planet>> getAllPlanets()
        {
            return _repository.getPlanets();
        }

        public string formatRequestPlanet(string planet)
        {
            return string.IsNullOrEmpty(planet) 
            ? planet 
            : Char.ToUpperInvariant(planet[0]) + planet.Substring(1).ToLowerInvariant();
        }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using testApi.Controllers.planets.planetutils;
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
        [Produces("application/json")]
        public ActionResult<Planet> getPlanet(string planet)
        {
            Planet result = _repository.getPlanetByName(PlanetRequestFormatter.formatRequestPlanet(planet));
            if (result == null)
            {
                return BadRequest(new { errorMessage = "Planet does not exist." });
            }
            return result;
        }

        [HttpGet("all")]
        [Produces("application/json")]
        public ActionResult<List<Planet>> getAllPlanets()
        {
            return _repository.getPlanets();
        }

    }
}
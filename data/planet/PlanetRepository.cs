
using System.Collections.Generic;
using System.Linq;

namespace testApi.data
{
    public class PlanetRepository : IPlanetRepository
    {

        private readonly PlanetContext _context;

        public PlanetRepository(PlanetContext context)
        {
            this._context = context;
        }
        
        public Planet GetPlanetByName(string planet)
        {
            return _context.Planets.Find(planet);
        }

        public List<Planet> GetPlanets()
        {
            return _context.Planets.ToList();
        }

    }
}
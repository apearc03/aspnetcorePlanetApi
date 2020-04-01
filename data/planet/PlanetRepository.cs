
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
        
        public Planet getPlanetByName(string planet)
        {
            return _context.Planets.Find(planet);
        }

        public List<Planet> getPlanets()
        {
            return _context.Planets.ToList();
        }

    }
}
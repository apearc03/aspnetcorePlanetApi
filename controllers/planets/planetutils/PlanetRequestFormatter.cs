using System;

namespace testApi.Controllers.planets.planetutils
{
    public class PlanetRequestFormatter{

        public static string formatRequestPlanet(string planet)
        {
            return string.IsNullOrEmpty(planet) 
            ? planet 
            : Char.ToUpperInvariant(planet[0]) + planet.Substring(1).ToLowerInvariant();
        }
    }

}
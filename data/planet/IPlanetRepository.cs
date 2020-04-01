
using System;
using System.Collections.Generic;

namespace testApi.data
{
    public interface IPlanetRepository
    {
        Planet GetPlanetByName(string name);
        List<Planet> GetPlanets();

    }

}
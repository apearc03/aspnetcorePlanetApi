
using System;
using System.Collections.Generic;

namespace testApi.data
{
    public interface IPlanetRepository
    {
        Planet getPlanetByName(string name);
        List<Planet> getPlanets();

    }

}
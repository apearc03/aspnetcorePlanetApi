using System;
using testApi.Controllers.planets.planetutils;
using Xunit;

namespace testApi.test.planets.planetutils
{
    public class PlanetRequestFormatterTest
    {
        [Fact]
        public void formatPlanet()
        {
            string badFormat = "eARTH";
            String formatted = PlanetRequestFormatter.formatRequestPlanet(badFormat);
            Assert.Equal("Earth", formatted);
        }
    }
}
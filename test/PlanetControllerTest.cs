using Moq;
using testApi.data;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using testApi.Controllers;

namespace testApi.test
{
    public class PlanetControllerTest
    {

        [Fact]
        public void TestName()
        {
            //Given
            var earth = new Planet { name = "Earth" };
            var mars = new Planet { name = "Mars" };
            var planets = new List<Planet>
            {
                earth,
                mars
            };

            var mockRepository = new Mock<IPlanetRepository>();
            mockRepository.Setup(r => r.GetPlanets()).Returns(planets);
            mockRepository.Setup(r => r.GetPlanetByName("Earth")).Returns(earth);
            
            var controller = new PlanetController(mockRepository.Object);
            //When
            Planet p = controller.GetPlanet("Earth");

            //Then
            Assert.Equal(p, earth);
        }

        //test all planets
        //test name isn't present?
    }
}
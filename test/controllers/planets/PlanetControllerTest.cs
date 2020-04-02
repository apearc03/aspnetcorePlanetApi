using Moq;
using testApi.data;
using Xunit;
using System.Collections.Generic;
using testApi.Controllers.planets;
using Microsoft.AspNetCore.Mvc;
using System;

namespace testApi.test.planets
{
    public class PlanetControllerTest
    {
        private Planet earth;
        private Planet mars;
        private List<Planet> planets;
        private Mock<IPlanetRepository> mockRepository;
        private PlanetController controller;
        public PlanetControllerTest()
        {
            earth = new Planet { name = "Earth" };
            mars = new Planet { name = "Mars" };
            planets = new List<Planet>
            {
                earth,
                mars
            };

            mockRepository = new Mock<IPlanetRepository>();
            mockRepository.Setup(r => r.getPlanets()).Returns(planets);
            mockRepository.Setup(r => r.getPlanetByName("Earth")).Returns(earth);
            controller = new PlanetController(mockRepository.Object);
        }

        [Fact]
        public void getPlanet()
        {
            ActionResult<Planet> planet = controller.getPlanet("Earth");
            Assert.Equal(earth, planet.Value);
        }

        [Fact]
        public void getAllPlanets()
        {
            ActionResult<List<Planet>> planetsResponse = controller.getAllPlanets();
            Assert.Equal(planets, planetsResponse.Value);
        }

        [Fact]
        public void getNonExistingPlanet()
        {
            ActionResult<Planet> p = controller.getPlanet("doesNotExist");
            Assert.Null(p.Value);
        }

        [Fact]
        public void formatPlanet()
        {
            string badFormat = "eARTH";
            String formatted = controller.formatRequestPlanet(badFormat);
            Assert.Equal("Earth", formatted);
        }
    }
}
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
            var data = new List<Planet>
            {
                earth,
                mars
            }.AsQueryable();

          
            var mockDbSet = new Mock<DbSet<Planet>>();
            mockDbSet.As<IQueryable<Planet>>().Setup(m => m.Provider).Returns(data.Provider);
            mockDbSet.As<IQueryable<Planet>>().Setup(m => m.Expression).Returns(data.Expression);
            mockDbSet.As<IQueryable<Planet>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockDbSet.As<IQueryable<Planet>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<PlanetContext>();
            mockContext.Setup(c => c.Planets).Returns(mockDbSet.Object);

            var controller = new PlanetController(mockContext.Object);
            
            //When
            Planet p = controller.GetPlanet("Earth");

            //Then
            Assert.Equal(p, earth);
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace testApi.data
{
    public class PlanetContext : DbContext
    {

        public PlanetContext(DbContextOptions<PlanetContext> options) : base(options)
        {

        }

        public DbSet<Planet> Planets { get; set; }
    }
}
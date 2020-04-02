using System.ComponentModel.DataAnnotations;

namespace testApi
{
    public class Planet
    {
        [Required]
        [Key]
        public string name { get; set; }

        public float mass_septillion_kg { get; set; }

        public int diameter_km { get; set; }

        public int density_kg_per_cubic_meter { get; set; }

        public float gravity_m_per_second_squared { get; set; }

        public float escape_velocity_km_per_second { get; set; }

        public float rotation_period_hours { get; set; }

        public float length_of_day_hours { get; set; }

        public float distance_from_sun_in_million_km { get; set; }

        public float perihelion_in_million_km { get; set; }

        public float aphelion_in_million_km { get; set; }

        public float orbital_period_days { get; set; }

        public float orbital_velocity_km_per_second { get; set; }

        public float orbital_inclination_angle_degrees { get; set; }

        public float orbital_eccentricity { get; set; }

        public float obliquity_to_orbit_angle_degrees { get; set; }

        public int mean_temperature_celsius { get; set; }

        public float? surface_pressure_bars { get; set; }

        public int number_of_moons { get; set; }

        public bool ring_system { get; set; }

        public bool? global_magnetic_field { get; set; }


    }
}
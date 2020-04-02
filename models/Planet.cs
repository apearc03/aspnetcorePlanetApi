using System.ComponentModel.DataAnnotations;

namespace testApi
{
    public class Planet
    {
        [Required]
        [Key]
        public string name { get; set; }

        [Required]
        public float mass_septillion_kg { get; set; }

        [Required]
        public int diameter_km { get; set; }

        [Required]
        public int density_kg_per_cubic_meter { get; set; }

        [Required]
        public float gravity_m_per_second_squared { get; set; }

        [Required]
        public float escape_velocity_km_per_second { get; set; }

        [Required]
        public float rotation_period_hours { get; set; }

        [Required]
        public float length_of_day_hours { get; set; }

        [Required]
        public float distance_from_sun_in_million_km { get; set; }

        [Required]
        public float perihelion_in_million_km { get; set; }

        [Required]
        public float aphelion_in_million_km { get; set; }

        [Required]
        public float orbital_period_days { get; set; }

        [Required]
        public float orbital_velocity_km_per_second { get; set; }

        [Required]
        public float orbital_inclination_angle_degrees { get; set; }

        [Required]
        public float orbital_eccentricity { get; set; }

        [Required]
        public float obliquity_to_orbit_angle_degrees { get; set; }

        [Required]
        public int mean_temperature_celsius { get; set; }

        public float? surface_pressure_bars { get; set; }

        [Required]
        public int number_of_moons { get; set; }

        [Required]
        public bool ring_system { get; set; }
        
        public bool? global_magnetic_field { get; set; }

    }
}
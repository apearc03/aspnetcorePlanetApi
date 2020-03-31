using System.ComponentModel.DataAnnotations;

namespace testApi
{
    public class Planet
    {
        [Required]
        [Key]
        public string name { get; set; }

    }
}
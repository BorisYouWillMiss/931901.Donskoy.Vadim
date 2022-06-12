using System.ComponentModel.DataAnnotations;

namespace WebAppLab5.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string? name { get; set; }
        [Required]
        public string? address { get; set; }
        [Required]
        public string? phone { get; set; }
    }
}

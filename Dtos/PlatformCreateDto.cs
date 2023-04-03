using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get ; set;}

        [Required]
        public int Publisher { get; set; }

        [Required]
        public int Cost { get; set; }
    }
    
}
using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models 
{
    public class program 
    {
        [Key]
        [Required]
        public int Id { get; set;}

        [Required]
        public string Name { get ; set;}

        [Required]
        public int Publisher { get; set; }

        [Required]
        public int Cost { get; set; }
    }
}
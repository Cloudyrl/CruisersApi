using System.ComponentModel.DataAnnotations;

namespace CruisersApi.Resources
{
    public class SaveCruiserDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        public bool Status { get; set; }
        
        [Required]
        public int Capacity { get; set; }
        
        [Required]
        public int LoadingShipCap { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Line { get; set; }
        
        public string Picture { get; set; }
    }
}
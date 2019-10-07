using System;
using System.ComponentModel.DataAnnotations;

namespace CruisersApi.Resources
{
    public class SaveLayoverDto
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DepartureDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ArrivalDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int LocDeparture { get; set; }
        [Required]
        public int LocArrival { get; set; }
        [Required]
        public int CruiserId { get; set; }
    }
}
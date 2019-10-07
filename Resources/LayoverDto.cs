using System;

namespace CruisersApi.Resources
{
    public class LayoverDto
    {
        public int Id { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal Price { get; set; }
        public int LocDeparture { get; set; }
        public int LocArrival { get; set; }
        public int CruiserId { get; set; }
    }
}
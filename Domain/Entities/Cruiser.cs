using System.Collections.Generic;

namespace CruisersApi.Domain.Entities
{
    public class Cruiser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Capacity { get; set; }
        public int LoadingShipCap { get; set; }
        public string Model { get; set; }
        public string Line { get; set; }
        public string Picture { get; set; }

        public IList<Layover> Layovers { get; set; }
    }
}
namespace CruisersApi.Resources
{
    public class CruiserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Capacity { get; set; }
        public int LoadingShipCap { get; set; }
        public string Model { get; set; }
        public string Line { get; set; }
        public string Picture { get; set; }
    }
}
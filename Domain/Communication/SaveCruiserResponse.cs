using CruisersApi.Domain.Entities;

namespace CruisersApi.Domain.Communication
{
    public class SaveCruiserResponse: BaseResponse
    {
        public Cruiser Cruiser;
        private SaveCruiserResponse(bool success, string message, Cruiser cruiser) : base(success, message)
        {
            Cruiser = cruiser;
        }

        public SaveCruiserResponse(Cruiser cruiser) : this(true, string.Empty, cruiser){}

        public SaveCruiserResponse(string message) : this(false, message, null){}
    }
}
using CruisersApi.Domain.Entities;

namespace CruisersApi.Domain.Communication
{
    public class CruiserResponse: BaseResponse
    {
        public Cruiser Cruiser;
        private CruiserResponse(bool success, string message, Cruiser cruiser) : base(success, message)
        {
            Cruiser = cruiser;
        }

        public CruiserResponse(Cruiser cruiser) : this(true, string.Empty, cruiser){}

        public CruiserResponse(string message) : this(false, message, null){}
    }
}
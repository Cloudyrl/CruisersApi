using AutoMapper;
using CruisersApi.Domain.Entities;
using CruisersApi.Resources;

namespace CruisersApi.Mapping
{
    public class DtoToEntityProfile: Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<SaveCruiserDto, Cruiser>();
        }
    }
}
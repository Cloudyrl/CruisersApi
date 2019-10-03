using AutoMapper;
using CruisersApi.Domain.Entities;
using CruisersApi.Resources;

namespace CruisersApi.Mapping
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Cruiser, CruiserDto>();
        }
    }
}
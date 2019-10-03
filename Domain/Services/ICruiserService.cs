using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Communication;
using CruisersApi.Domain.Entities;
using CruisersApi.Resources;

namespace CruisersApi.Domain.Services
{
    public interface ICruiserService 
    {
        Task<IEnumerable<Cruiser>> GetCruisersAsync();

        Task<CruiserResponse> GetCruiserByIdAsync(int id);
        Task<CruiserResponse> SaveCruiserAsync(Cruiser cruiser);

        Task<CruiserResponse> UpdateCruiserAsync(int id,Cruiser cruiser);
    }
}
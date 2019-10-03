using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Entities;

namespace CruisersApi.Domain.Repository
{
    public interface ICruiserDAO
    { 
        Task<IEnumerable<Cruiser>> GetCruisersAsync();
        Task SaveCrusierAsync(Cruiser cruiser);
        Task<Cruiser> FindCruiserByIdAsync(int id);

        void UpdateCruiser(Cruiser cruiser);

        void DeleteCruiser(Cruiser cruiser);
    }
}
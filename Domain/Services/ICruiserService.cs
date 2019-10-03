using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Entities;

namespace CruisersApi.Domain.Services
{
    public interface ICruiserService 
    {
        Task<IEnumerable<Cruiser>> GetCruisersAsync();
    }
}
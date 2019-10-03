using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Entities;

namespace CruisersApi.Domain.Repository
{
    public interface ICruiserDAO
    {
        Task<IEnumerable<Category>> GetCruisersAsync();
    }
}
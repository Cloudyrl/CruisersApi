using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Entities;

namespace CruisersApi.Domain.Repository
{
    public interface ICategoryDAO
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
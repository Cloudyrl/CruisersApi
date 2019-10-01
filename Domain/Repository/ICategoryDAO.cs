using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Domain.Entities;

namespace webapi.Domain.Repository
{
    public interface ICategoryDAO
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
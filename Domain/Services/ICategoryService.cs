using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Domain.Entities;

namespace webapi.Domain.Services
{
    public interface ICategoryService 
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
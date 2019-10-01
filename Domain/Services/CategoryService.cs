using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Domain.Entities;

namespace webapi.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}

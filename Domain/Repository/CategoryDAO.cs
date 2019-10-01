using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Domain.Entities;

namespace webapi.Domain.Repository
{
    public class CategoryDAO: ICategoryDAO
    {
        public Task<IEnumerable<Category>> GetCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}
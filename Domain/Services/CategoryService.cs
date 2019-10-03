using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Repository;

namespace CruisersApi.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDAO _categoryDao;

        public CategoryService(ICategoryDAO categoryDao)
        {
            _categoryDao = categoryDao; 
        }
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var categories = await _categoryDao.GetCategories();
            return categories;
        }
    }
}

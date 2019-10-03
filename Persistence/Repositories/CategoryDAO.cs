using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CruisersApi.Domain.Entities;
using CruisersApi.Persistence.Contexts;
using CruisersApi.Persistence.Repositories;

namespace CruisersApi.Domain.Repository
{
    public class CategoryDAO: BaseRepository ,ICategoryDAO
    {
        public CategoryDAO(AppDbContext context) : base(context){}
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
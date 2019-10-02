using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi.Domain.Entities;
using webapi.Persistence.Contexts;
using webapi.Persistence.Repositories;

namespace webapi.Domain.Repository
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
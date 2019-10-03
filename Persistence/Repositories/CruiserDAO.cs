using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CruisersApi.Domain.Entities;
using CruisersApi.Persistence.Contexts;
using CruisersApi.Persistence.Repositories;

namespace CruisersApi.Domain.Repository
{
    public class CruiserDAO: BaseRepository ,ICruiserDAO
    {
        public CruiserDAO(AppDbContext context) : base(context){}
        public async Task<IEnumerable<Cruiser>> GetCruisersAsync()
        {
            return await _context.Cruiser.ToListAsync();
        }

        public async Task SaveCrusierAsync(Cruiser cruiser)
        {
            await _context.Cruiser.AddAsync(cruiser);
        }

        public async Task<Cruiser> FindCruiserByIdAsync(int id)
        {
            return await _context.Cruiser.FindAsync(id);
        }

        public void UpdateCruiser(Cruiser cruiser)
        {
            _context.Cruiser.Update(cruiser);
        }
    }
}
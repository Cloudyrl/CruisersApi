using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Repository;

namespace CruisersApi.Domain.Services
{
    public class CruiserService : ICruiserService
    {
        private readonly ICruiserDAO _cruiserDao;

        public CruiserService(ICruiserDAO cruiserDao)
        {
            _cruiserDao = cruiserDao; 
        }

        public async Task<IEnumerable<Category>> GetCruisersAsync()
        {
           return await _cruiserDao.GetCruisersAsync();
        }
    }
}

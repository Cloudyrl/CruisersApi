using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Services;
using CruisersApi.Resources;

namespace CruisersApi.Controllers
{
    public class CruiserController : Controller
    {
        private ICruiserService _cruiserService;
        private IMapper _mapper;
        
        public CruiserController(ICruiserService cruiserService, IMapper mapper)
        {
            _cruiserService = cruiserService;
            _mapper = mapper;
        }

        [Route("/api/[Controller]")]
        // GET
        public async Task<IEnumerable<CruiserDto>> GetCategoriesAsync()
        {
            var cruisers = await _cruiserService.GetCruisersAsync();
            var cruisersDto = _mapper.Map<IEnumerable<Cruiser>, IEnumerable<CruiserDto>>(cruisers);
            return cruisersDto;
        }
    }
}
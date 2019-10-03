using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Services;
using CruisersApi.Resources;
using CruisersApi.Extensions;

namespace CruisersApi.Controllers
{
    [Route("/api/[Controller]")]
    public class CruiserController : Controller
    {
        private ICruiserService _cruiserService;
        private IMapper _mapper;
        
        public CruiserController(ICruiserService cruiserService, IMapper mapper)
        {
            _cruiserService = cruiserService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CruiserDto>> GetCategoriesAsync()
        {
            var cruisers = await _cruiserService.GetCruisersAsync();
            var cruisersDto = _mapper.Map<IEnumerable<Cruiser>, IEnumerable<CruiserDto>>(cruisers);
            return cruisersDto;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCruiserByIdAsync(int id)
        {
            var response = await _cruiserService.GetCruiserByIdAsync(id);
            if (!response.Success) return NotFound();
            var cruiserDto = _mapper.Map<Cruiser, CruiserDto>(response.Cruiser);
            return Ok(cruiserDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCruiserDto saveCruiserDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());
            var cruiser = _mapper.Map<SaveCruiserDto, Cruiser>(saveCruiserDto);
            var response = await _cruiserService.SaveCruiserAsync(cruiser);
            if (!response.Success) return BadRequest(response.Message);
            var cruiserDto = _mapper.Map<Cruiser, CruiserDto>(response.Cruiser);
            return Ok(cruiserDto);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> PutAsync(int id,[FromBody] SaveCruiserDto saveCruiserDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());
            var cruiser = _mapper.Map<SaveCruiserDto, Cruiser>(saveCruiserDto);
            var response = await _cruiserService.UpdateCruiserAsync(id,cruiser);
            if (!response.Success) return BadRequest(response.Message);
            var savedCruiser = _mapper.Map<Cruiser, CruiserDto>(response.Cruiser);
            return Ok(savedCruiser);
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Services;

namespace CruisersApi.Controllers
{
    public class CruiserController : Controller
    {
        private ICruiserService _cruiserService;
        
        public CruiserController(ICruiserService cruiserService)
        {
            _cruiserService = cruiserService;
        }

        [Route("/api/[Controller]")]
        // GET
        public async Task<IEnumerable<Cruiser>> GetCategoriesAsync()
        {
            var response = await _cruiserService.GetCruisersAsync();
            return response;
        }
    }
}
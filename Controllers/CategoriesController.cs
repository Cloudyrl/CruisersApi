using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Services;

namespace CruisersApi.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService _categoryService;
        
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("/api/[Controller]")]
        // GET
        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var response = _categoryService.GetCategoriesAsync();
            return response;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Domain.Entities;
using webapi.Domain.Services;

namespace webapi.Controllers
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.API.Application.Queries;
using Sample.Domain;

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryQueries _categoryQueries;
        public CategoryController(ICategoryQueries categoryQueries)
        {
            _categoryQueries = categoryQueries;
        }

        [Route("{categoryId}/subcategories")]
        [HttpGet]
        public async Task<IActionResult> GetSubcategories(int categoryId)
        {
            var result = await _categoryQueries.GetAllSubcategories(categoryId);
            return Ok(result);
        }
    }
}

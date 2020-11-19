using Sample.API.Application.DTOs;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sample.API.Application;

namespace Sample.API.Application.Queries
{
    public class CategoryQueries : ICategoryQueries
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryQueries(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<SubcategoryDTO>> GetAllSubcategories(int categoryId)
        {
             var result = await _categoryRepository.GetSubcategories(categoryId);
            
             return result.ToListSubcategoryDTO();
        }
    }
}

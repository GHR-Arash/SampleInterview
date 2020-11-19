using Sample.API.Application.DTOs;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Application.Queries
{
    public interface ICategoryQueries
    {
        Task<List<SubcategoryDTO>> GetAllSubcategories(int categoryId);
    }
}

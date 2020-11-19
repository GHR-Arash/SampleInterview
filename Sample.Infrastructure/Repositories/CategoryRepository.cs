using Microsoft.EntityFrameworkCore;
using Sample.Domain;
using Sample.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SampleContext _context;

        public CategoryRepository(SampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Subcategory>> GetSubcategories(int CategoryId)
        {
            return await _context.TagMaps.Where(m => m.Category.Id == CategoryId)
                             .Select(s => s.SubCategory).ToListAsync();

        }
    }
}

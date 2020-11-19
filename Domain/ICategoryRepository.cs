using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain
{
    public interface ICategoryRepository
    {
        Task<List<Subcategory>> GetSubcategories(int CategoryId);
    }

   
}

using Sample.API.Application.DTOs;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Application
{
    public static class Extensions
    {
        public static List<SubcategoryDTO>  ToListSubcategoryDTO(this List<Subcategory> categorey)
        {
            var result = new List<SubcategoryDTO>();

            categorey.ForEach (i =>
            {
                result.Add(new SubcategoryDTO() { name = i.Name });

            }) ;

            return result;

        }
    }
}

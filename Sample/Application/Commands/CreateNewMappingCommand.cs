using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Application.Commands
{
    public class CreateNewMappingCommand:IRequest<bool>
    {
        public int TagId { get; set; }
        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }
        public CreateNewMappingCommand()
        {

        }
        public CreateNewMappingCommand(int tagId,int categoryId,int subCategoryId)
        {
            this.TagId = tagId;
            this.CategoryId = categoryId;
            this.SubcategoryId = subCategoryId;
        }
    }
}

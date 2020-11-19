using Sample.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain
{
    public interface ITagMapRepository : IRepository<TagMap>
    {
        TagMap Add(TagMap tagMap);
        Task<TagMap> FindByIdAsync(int id);
    }
}

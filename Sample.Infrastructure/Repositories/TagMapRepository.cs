using Sample.Domain;
using Sample.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure.Repositories
{
    public class TagMapRepository : ITagMapRepository
    {
        private readonly SampleContext _context;

        public TagMapRepository(SampleContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork { get { return _context; } }

        public TagMap Add(TagMap tagMap)
        {
    
            return  _context.TagMaps.Add(tagMap).Entity;
        }

        public Task<TagMap> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using MediatR;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.API.Application.Commands
{
    public class CreateNewMappingCommandHandler : IRequestHandler<CreateNewMappingCommand, bool>
    {

        private readonly ITagMapRepository _tagMapRepository;
        public CreateNewMappingCommandHandler(ITagMapRepository tagMapRepository)
        {
            _tagMapRepository = tagMapRepository;
        }

        public async Task<bool> Handle(CreateNewMappingCommand request, CancellationToken cancellationToken)
        {
            var tagMap = new TagMap(request.TagId, request.CategoryId, request.SubcategoryId);
            var result = _tagMapRepository.Add(tagMap);
            var commandResult= await _tagMapRepository.UnitOfWork.SaveEntitiesAsync();
            return commandResult;
        }
    }
}

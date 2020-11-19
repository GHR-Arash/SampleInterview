using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.API.Application.Commands;

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MappingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MappingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewPlan(CreateNewMappingCommand request)
        {
            var result = await _mediator.Send(new CreateNewMappingCommand(request.TagId, request.CategoryId, request.SubcategoryId));
            return Ok(result);
        }
    }
}

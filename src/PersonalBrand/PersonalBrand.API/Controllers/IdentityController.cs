﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PersonalBrand.Application.UseCases.IdentityCases.Commands;
using PersonalBrand.Application.UseCases.IdentityCases.Queries;

namespace PersonalBrand.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IdentityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Rergister(CreateUserCommand createUserCommand)
        {
            var result = await _mediator.Send(createUserCommand);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserCommand updateUserCommand)
        {
            var result = await _mediator.Send(updateUserCommand);

            return Ok(result);
        }



    }
}

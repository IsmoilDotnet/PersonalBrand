using MediatR;
using Microsoft.AspNetCore.Identity;
using PersonalBrand.Application.Abstractions;
using PersonalBrand.Application.UseCases.IdentityCases.Queries;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Application.UseCases.IdentityCases.Handlers.QueryHandlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserModel>>
    {
        private readonly UserManager<UserModel> _userManager;

        public GetAllUsersQueryHandler(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IEnumerable<UserModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var result = _userManager.Users.ToImmutableList();

            return result;
        }
    }
}

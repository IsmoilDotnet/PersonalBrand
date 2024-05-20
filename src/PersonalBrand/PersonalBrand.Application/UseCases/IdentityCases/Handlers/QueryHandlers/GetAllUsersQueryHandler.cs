using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using PersonalBrand.Application.UseCases.IdentityCases.Queries;
using PersonalBrand.Domain.Entities;
using System.Collections.Immutable;

namespace PersonalBrand.Application.UseCases.IdentityCases.Handlers.QueryHandlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserModel>>
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly IMemoryCache _memoryCache;

        public GetAllUsersQueryHandler(UserManager<UserModel> userManager, IMemoryCache memoryCache)
        {
            _userManager = userManager;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<UserModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            object userModel = _memoryCache.Get("users");
            if (userModel == null)
            {
                ImmutableList<UserModel>? userModel1 = _userManager.Users.ToImmutableList();
                _memoryCache.Set("users", userModel1);
            }

            return userModel as IEnumerable<UserModel>;
        }
    }
}

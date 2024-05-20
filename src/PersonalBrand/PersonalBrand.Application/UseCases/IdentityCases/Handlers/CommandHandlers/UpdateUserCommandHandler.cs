using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using PersonalBrand.Application.UseCases.IdentityCases.Commands;
using PersonalBrand.Domain.Entities;

namespace PersonalBrand.Application.UseCases.IdentityCases.Handlers.CommandHandlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResponseModel>
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly IMemoryCache _memoryCache;

        public UpdateUserCommandHandler(UserManager<UserModel> userManager, IMemoryCache memoryCache)
        {
            _userManager = userManager;
            _memoryCache = memoryCache;
        }

        public async Task<ResponseModel> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            _memoryCache.Remove("users");

            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Email = request.Email;
                user.PhoneNumber = request.PhoneNumber;
                user.UserName = request.UserName;

                var result = await _userManager.UpdateAsync(user);

                return new ResponseModel
                {
                    Message = "Updated",
                    IsSuccess = true,
                    StatusCode = 204
                };
            }

            return new ResponseModel
            {
                Message = "User Not Found",
                IsSuccess = true,
                StatusCode = 404
            };
        }
    }
}

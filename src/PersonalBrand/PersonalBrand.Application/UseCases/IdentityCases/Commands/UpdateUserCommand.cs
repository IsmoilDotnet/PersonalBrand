using MediatR;
using PersonalBrand.Domain.Entities;

namespace PersonalBrand.Application.UseCases.IdentityCases.Commands
{
    public class UpdateUserCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}

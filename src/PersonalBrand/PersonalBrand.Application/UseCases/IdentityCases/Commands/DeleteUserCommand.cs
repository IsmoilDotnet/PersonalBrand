using MediatR;
using PersonalBrand.Domain.Entities;

namespace PersonalBrand.Application.UseCases.IdentityCases.Commands
{
    public class DeleteUserCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}

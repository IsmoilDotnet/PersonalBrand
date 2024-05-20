using MediatR;
using PersonalBrand.Domain.Entities;

namespace PersonalBrand.Application.UseCases.IdentityCases.Queries
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserModel>>
    {

    }
}

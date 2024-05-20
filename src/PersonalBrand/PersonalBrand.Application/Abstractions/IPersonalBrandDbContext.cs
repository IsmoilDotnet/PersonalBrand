using Microsoft.EntityFrameworkCore;
using PersonalBrand.Domain.DTOs;

namespace PersonalBrand.Application.Abstractions
{
    public interface IPersonalBrandDbContext
    {
        public DbSet<Login> TestLoginTable { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

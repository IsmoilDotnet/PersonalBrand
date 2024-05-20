using Microsoft.AspNetCore.Identity;

namespace PersonalBrand.Domain.Entities
{
    public class UserModel : IdentityUser, IAuditable
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset ModifiedDate { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

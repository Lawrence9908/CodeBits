using Microsoft.AspNetCore.Identity;

namespace CodeBits.API.Entities
{
    public class AppUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}

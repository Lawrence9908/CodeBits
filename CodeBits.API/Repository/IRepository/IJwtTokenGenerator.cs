using CodeBits.API.Entities;

namespace CodeBits.API.Repository.IRepository
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(AppUser user, IEnumerable<string> roles);
    }
}

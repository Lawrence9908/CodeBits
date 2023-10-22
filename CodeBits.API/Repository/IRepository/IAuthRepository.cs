using CodeBits.API.Models.Dtos;

namespace CodeBits.API.Repository.IRepository
{
    public interface IAuthRepository
    {
        Task<string> Register(RegisterRequestDto registerRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}

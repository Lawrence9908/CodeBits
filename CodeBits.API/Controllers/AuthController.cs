using CodeBits.API.Data;
using CodeBits.API.Models.Dtos;
using CodeBits.API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CodeBits.API.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepository;
        protected ResponseDto _response;
        public AuthController(IAuthRepository authRepository, ApplicationDbContext context)
        {
            _authRepository = authRepository;
            _response = new();
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var errorMessage = await _authRepository.Register(registerRequestDto);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccesss = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var loginResponse = await _authRepository.Login(loginRequestDto);
            if (loginResponse.User == null)
            {
                _response.IsSuccesss = false;
                _response.Message = "Username or password is incorrent";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }
        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegisterRequestDto registerRequestDto)
        {
            var assignRoleSuccessful = await _authRepository.AssignRole(registerRequestDto.Email, registerRequestDto.Role.ToUpper());
            if (assignRoleSuccessful)
            {
                _response.IsSuccesss = false;
                _response.Message = "Error encountered";
                return BadRequest(_response);
            }
            return Ok(_response);
        }
    }
}


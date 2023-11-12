using System.ComponentModel.DataAnnotations;

namespace CodeBits.API.Models.Dtos
{
    public class RegisterRequestDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

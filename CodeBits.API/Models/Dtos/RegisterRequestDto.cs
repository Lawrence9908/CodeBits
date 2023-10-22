﻿using System.ComponentModel.DataAnnotations;

namespace CodeBits.API.Models.Dtos
{
    public class RegisterRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

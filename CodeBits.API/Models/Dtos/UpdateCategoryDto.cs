using System.ComponentModel.DataAnnotations;

namespace CodeBits.API.Models.Dtos
{
    public class UpdateCategoryDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

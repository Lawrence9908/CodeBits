using System.ComponentModel.DataAnnotations;

namespace CodeBits.API.Models.Dtos
{
    public class AddCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}

using CodeBits.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Models.Dtos
{
    public class AddArticleDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}

using CodeBits.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeBits.API.Models.Dtos
{
    public class ViewArticlerDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl { get; set; }
        public int CommentCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        //public string UserId { get; set; }
        public UserDto User { get; set; }
        public int CategoryId { get; set; }
        public ICollection<ViewCommentDto> Comments { get; set; }
    }
}
